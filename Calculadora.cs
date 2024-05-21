namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato; //campo privado para almacenar el resuktado de las operaciones
        private double Dato { get => dato; set => dato = value; }
        public double Resultado { get => dato; }
        public void Sumar(double termino){
            Dato = Dato + termino; //suma el valor del parámetro termino al campo dato 
        }
        public void Restar(double termino){
            Dato = Dato - termino; 
        }
        public void Multiplicar(double termino){
            Dato = Dato * termino; 
        }
        public void Dividir(double termino){
            if (termino != 0)
            {
                Dato = Dato/termino; 
            } else {
                Console.WriteLine("ERROR: División por cero."); 
            }
        }
        public void Limpiar(){ //método para limpiar el campo dato
            Dato = 0; 
        }
    }
}
