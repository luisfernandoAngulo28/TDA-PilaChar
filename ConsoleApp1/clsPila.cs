using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class clsPila
    {
        //ATRIBUTOS
        public const int MAX = 10;
        private int _top;
        private Char[] _pila;

        //CONSTRUCTOR
        public clsPila()
        {
            _top = -1;
            _pila = new Char[MAX];
        }

        //METODOS
        public clsPila(clsPila p)
        {
            _top = p._top;
            _pila = new Char[MAX];
            for (int i = 0; i < p._top; i++)
            {
                _pila[i] = p._pila[i];
            }
        }

        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }
        public Char[] Pila
        {
            get { return _pila; }
            set { _pila = value; }
        }

        // Destruye la Pila
        public void Drop()
        {
            _top = -1;
        }

        // Valida si la Pila esta vacia
        public Boolean Vacia()
        {
            if (_top == -1)
            {
                return true;
            }
            return false;
        }

        // Obtiene el elemento de la Cima de la Pila 
        public int Tope()
        {
            if (Vacia() != true)
                return _pila[_top];
            return 0;
        }

        // Adiciona un elemento en la cima de la Pila
        public void Add(Char e)
        {
            {
                if (Llena() != true)
                {
                    _top++;
                    _pila[_top] = e;
                }
            }
        }

        // Elimina el elemento de la cima de la Pila
        public void Delete()
        {
            if (Vacia() != true)
                _top--;
        }

        // Valida si la Pila esta llena
        public Boolean Llena()
        {
            if (_top + 1 == MAX)
            {
                return true;
            }
            return false;
        }


        // Obtiene la cantidad de elementos en la Pila 
        public int Long()
        {
            return _top + 1;
        }

        // Imprime los elementos de la Pila 
        public string Imprimir()
        {
            string salida = "";
            for (int i = 0; i <= _top; i++)
            {
                salida += "[ " + _pila[i].ToString() + " ]";
            }
            return salida;
        }
        // retorna el elemento del fondo de la pila
        public int Rear()
        {
            int e = 0;
            for (int i = 0; i < 1; i++)
            {
                e = e + _pila[i];
            }
            return e;
        }
        
        //Extraer
        public Char extraer(int pos)
        {
            Char informacion = '0';
            if (!Vacia())
            {
                for(int i = 0; i <= _top; i++)
                {
                    if (i == pos)
                    {
                        informacion = _pila[i];
                    }
                }
                return informacion;
            }
            else
            {
                return informacion;
            }
        }


        public Boolean balanceada(String S)
        {
            Boolean B = false;
            clsPila pila1 = new clsPila();
            String cadena = S;
            for (int f = 0; f <= cadena.Length; f++)
            {
                if(cadena[f]=='('|| cadena[f] == '[' || cadena[f] == '{')
                {
                    pila1.Add(cadena[f]);
                    /* pila=[ '(' ]
                            [ '[' ]
                            [ '{' ]  */
                }
                else
                {
                    if (cadena[f] == ')')
                    {
                        for (int i = 0; i <= pila1._top; i++)
                        {
                            if(pila1.extraer(i) != '(')
                            {
                                B = false;
                            }
                            else
                            {
                                B = true;
                            }
                        }
                        return B;
                    }
                    else
                    {
                        if (cadena[f] == ']')
                        {
                            for (int i = 0; i <= pila1._top; i++)
                            {
                                if (pila1.extraer(i) != ']')
                                {
                                    B = false;
                                }
                                else
                                {
                                    B = true;
                                }
                            }
                            return B;
                        }
                        else
                        {
                            if (cadena[f] == '}')
                            {
                                for (int i = 0; i <= pila1._top; i++)
                                {
                                    if (pila1.extraer(i) != '{')
                                    {
                                        B = false;
                                    }
                                    else
                                    {
                                        B = true;
                                    }
                                }
                                return B;
                            }
                        }
                    }
                }
            }
            if (pila1.Vacia())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
