
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lite
{
    public partial class Form1 : Form
    {
        ProdutoContext? dbContext;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbContext = new ProdutoContext();
            dbContext.Database.EnsureCreated();
            dbContext.Categorias.Load();
            categoriaBindingSource.DataSource = dbContext.Categorias.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            dbContext?.Dispose();
            dbContext = null;
        }


        public Form1()
        {
            InitializeComponent();
        }
    }
}
