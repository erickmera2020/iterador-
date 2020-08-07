
using iterdorexpo;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterdorexpo
{
    class CContenedora : IEnumerable
    {
        private int[] valores = new int[10];

        public CContenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n * n;
        }

        // Implementamos el GetEnumerator necesario por IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Instanciamos el enumerador y lo regresamos
       
            return (new Contenedorenum(valores));
        }
    }

    class Contenedorenum: IEnumerator  
    {
        public int[] arreglo;
        private int posicion = -1;

        public Contenedorenum (int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        // Indica con true o false si hay siguiente
        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
                return true;
            else
                return false;
        }

        // Nos devuelve al inicio de la coleccion
        public void Reset()
        {
            posicion = -1;
        }

        // Devuelve el elemento en el que estamos parados
        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }
    }
}


