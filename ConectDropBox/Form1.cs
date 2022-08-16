using Dropbox.Api;
using Dropbox.Api.Files;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectDropBox
{
    public partial class Form1 : Form
    {
        static string token = "????";
        static string nome;
        static string email;
        static string pais;
        static ArrayList entradas = new ArrayList();

        static string source_folder;
        static string target_folder;
        static string file;

        public Form1()
        {
            InitializeComponent();

            //Listar Arquivos do Local
            string[] arquivos = Directory.GetFiles(lbLocal.Text);
            foreach (string arquivo in arquivos)
                listLocal.Items.Add(Path.GetFileName(arquivo));

            var task = Task.Run(Run);
            try
            {
                task.Wait();
                lbNome.Text = $"Nome: {nome}"; //Nome: " + nome
                lbEmail.Text = $"Email: {email}";
                lbPais.Text = $"Pais: {pais}";
                foreach (string item in entradas)
                {
                    listDropBox.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao se conectar");
            }
        }

        async Task Run()
        {
            using (var dbx = new DropboxClient(token))
            {
                var id = await dbx.Users.GetCurrentAccountAsync();
                nome = id.Name.DisplayName;
                email = id.Email;
                pais = id.Country;

                // mostrar as pastas
                var folder = lbDropBox.Text;
                try
                {
                    var list = await dbx.Files.ListFolderAsync(folder);
                    foreach (var item in list.Entries.Where(i => i.IsFile))
                        entradas.Add(item.Name);
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao mostrar arquivos");
                }
            }
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            source_folder = lbLocal.Text;
            target_folder = lbDropBox.Text;
            file = listLocal.SelectedItem.ToString();

            var task = Task.Run(Upload);
            try
            {
                task.Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Upload" + ex);
            }
        }

        async Task Upload()
        {
            using (var dbx = new DropboxClient(token))
            {
                using (var content = new MemoryStream(File.ReadAllBytes(source_folder + file)))
                {
                    var update = await dbx.Files.UploadAsync(target_folder + file, WriteMode.Overwrite.Instance,
                        body: content);

                    var url = "https://www.dropbox.com/home/" + target_folder + file;
                    MessageBox.Show("Upload Ralizado " + url);
                }
            }
        }

        private void btDowload_Click(object sender, EventArgs e)
        {
            source_folder = lbDropBox.Text;
            target_folder = lbLocal.Text;
            file = listDropBox.SelectedItem.ToString();

            var task = Task.Run(Download);
            try
            {
                task.Wait();
                MessageBox.Show("Donwload " + listLocal.SelectedItem + " realizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Download" + ex);
            }
        }

        async Task Download()
        {
            using (var dbx = new DropboxClient(token))
            {
                using (var response = await dbx.Files.DownloadAsync(source_folder + file))
                {
                    var content = response.GetContentAsByteArrayAsync();
                    content.Wait();
                    File.WriteAllBytes(target_folder + file, content.Result);
                }
            }
            
        }
    }
}
