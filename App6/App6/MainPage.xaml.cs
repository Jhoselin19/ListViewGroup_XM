using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Estudiante> estudiantes1 = new List<Estudiante>
            {
                new Estudiante { Nombres = "Juan", Apellidos = "Pérez", Edad = 19, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Ana", Apellidos = "García", Edad = 20, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Carlos", Apellidos = "Rodríguez", Edad = 21, Seccion = "Seccion A" },
                new Estudiante { Nombres = "María", Apellidos = "Martínez", Edad = 22, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Javier", Apellidos = "Hernández", Edad = 23, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Laura", Apellidos = "López", Edad = 24, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Sergio", Apellidos = "González", Edad = 25, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Carmen", Apellidos = "Morales", Edad = 26, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Fernando", Apellidos = "Guerrero", Edad = 27, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Patricia", Apellidos = "Ramírez", Edad = 28, Seccion ="Seccion D" },
                new Estudiante { Nombres = "Ricardo", Apellidos ="Aguilar", Edad=29, Seccion="Seccion D"},
                new Estudiante { Nombres ="Luisa", Apellidos="Peña", Edad=30, Seccion="Seccion D"},
                new Estudiante { Nombres ="Roberto", Apellidos="Navarro", Edad=31, Seccion="Seccion D"},
                new Estudiante { Nombres ="Isabel", Apellidos="Romero", Edad=32, Seccion="Seccion D"},
                new Estudiante { Nombres ="Pedro", Apellidos="Torres", Edad=33, Seccion="Seccion D"},
            };

            // Agrupar los estudiantes por sección usando LINQ
            // El método GroupBy crea un nuevo grupo para cada sección única en la lista de estudiantes

            var groupedStudents = estudiantes1.GroupBy(e => e.Seccion);

            // Asignar los grupos de estudiantes al ListView
            // ListView mostrará automáticamente los estudiantes agrupados por sección

            lvEstudiantes1.ItemsSource = groupedStudents;
        }
    }
}
