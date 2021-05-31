using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppelourd
{
    class Commande
    {
        private int ref_com;
        public int Ref_com
        {
            get
            {
                return ref_com;
            }
        }



        private string date_commande;
        public string Date_commande
        {
            get
            {
                return date_commande;
            }
            set
            {
                date_commande = value;
            }
        }

        

       
        private string total;
        public string Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        private string id_u;
        public string Id_u
        {
            get
            {
                return id_u;
            }
            set
            {
                id_u = value;
            }
        }
        public Commande(int ref_com,string date_commande, string id_u ,string total)
        {
            this.ref_com = ref_com;
            this.date_commande = date_commande;
            
            this.total = total;
            this.id_u = id_u;
        }
    }
}