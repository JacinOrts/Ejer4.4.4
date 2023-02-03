internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Introduzca numero de alumnos: ");
        int n = int.Parse(Console.ReadLine());
        Alumno[] alumnos = new Alumno[n];
        
        for(int i = 0; i< n; i++)
        {
            Console.Write("Introduzca NOMBRE del alumno " + (i + 1) + ": ");
            string nombre = Console.ReadLine();            
            Console.Write("Introduzca NOTA 1 del alumno " + (i + 1) + ": ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca NOTA 2 del alumno " + (i + 1) + ": ");
            int nota2 = int.Parse(Console.ReadLine());
            alumnos[i] = new Alumno(nombre, nota1, nota2);           
        }

        double suma = 0;
        double promedio = 0;

        for(int i=0; i<n; i++)
        {
            suma = alumnos[i].getNota1() + alumnos[i].getNota2();
            promedio = suma / 2;
            Console.WriteLine("El NOMBRE del alumno es: " + alumnos[i].getNombre());
            Console.WriteLine("la NOTA 1 es: " + alumnos[i].getNota1());
            Console.WriteLine("la NOTA 2 es: " + alumnos[i].getNota2());
            Console.WriteLine("el PROMEDIO es: " + promedio);
        }        
    }
    
}

public class Alumno
{
    string nombre;
    int nota1;
    int nota2;

    public Alumno() { }

    public Alumno(string nombre, int nota1, int nota2)
    {
        this.nombre = nombre;
        this.nota1 = nota1;
        this.nota2 = nota2;
    }

    public String getNombre()
    {
        return nombre;
    }

    public int getNota1()
    {
        return nota1;
    }

    public int getNota2()
    {
        return nota2;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void setNota1(int nota1)
    {
        this.nota1 = nota1;
    }

    public void setNota2(int nota2)
    {
        this.nota2 = nota2;
    }


}