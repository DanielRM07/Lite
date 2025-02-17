using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lite
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ObservableCollectionListSource<Produto> Produto { get; } = new ObservableCollectionListSource<Produto>();
    }
}
