using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_POO
{
    class De
    {
        char[] faces = new char[6];
        char lettreVisible;

        public De(char[] faces)
        {
            this.faces = faces;
            Random r = new Random();
            Lance(r);
        }

        public void Lance(Random r)
        {

            // Generate a random index less than the size of the array.  
            int index = r.Next(faces.Length);
            lettreVisible = faces[index];
        }
        public char returnValeur() { return lettreVisible; }

        public string ToString()
        {
            string result = "";
            result += "Le dé est composé des faces suivantes :" + faces[0] + "," + faces[1] + "," + faces[2] + "," + faces[3] + "," + faces[4] + "," + faces[5] + ".";
            return result;
        }
    }
}
