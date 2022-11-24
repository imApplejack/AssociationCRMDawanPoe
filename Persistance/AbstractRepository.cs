using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationCRMDawanPoe.Persistance
{
    public class AbstractRepository
    {
        public string ConnexionString { get; set; }

        public AbstractRepository(string connexionString)
        {
            ConnexionString = connexionString;
        }
    }
}
