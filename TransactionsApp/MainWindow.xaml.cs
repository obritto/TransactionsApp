using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TransactionsApp.Models;

namespace TransactionsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            dadosModel db = new dadosModel();

            using (DbContextTransaction transaction = db.Database.BeginTransaction())
            {
                //var joao = db.Pessoa.FirstOrDefault(it => it.idPessoa == 2);

                //decimal valor = joao.poupanca;

                //joao.poupanca = 0;

                //db.SaveChanges();

                var tiago = db.Pessoa.FirstOrDefault(it => it.idPessoa == 1);

                tiago.poupanca = -100000;

                db.SaveChanges();

                //transaction.Rollback();
                transaction.Commit();
            }
        }
    }
}
