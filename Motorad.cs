using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Klasse_HausAufgabe
{
   class Motorad
     {

        private string Model;
        private string Farbe;
        private int Jahr;

       
       
         public void SetModel()
         {
             this.Model = Model;
         }

         public void SetFarbe()
         {
             this.Farbe = Farbe;
         }
         public void SetJahr()
         {
             this.Jahr = Jahr;
         }

         public string GetModel()
         {
             return this.Model;
         }

         public string GetFarbe()
         {
             return this.Farbe;
         }

         public int GetJahr()
         {
             return this.Jahr;
         }

         public Motorad(string modelMot, string farbeMot, int jahrMot ) 
         { 
             this.Model= modelMot;
             this.Farbe= farbeMot;
             this.Jahr= jahrMot;
         }
        

    }
}
