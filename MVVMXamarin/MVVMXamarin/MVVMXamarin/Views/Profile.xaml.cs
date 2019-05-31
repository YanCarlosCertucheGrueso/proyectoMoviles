using MVVMXamarin.Models;
using MVVMXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Profile : ContentPage
	{
        UsuarioViewModel context = new UsuarioViewModel();

		public Profile()
		{
			InitializeComponent ();
            BindingContext = context;
            LvUsuarios.ItemSelected += LvUsuarios_ItemSelected;
		}

        private void LvUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Usuario modelo = (Usuario)e.SelectedItem;
                context.Nombre = modelo.Nombre;
                context.Apellido = modelo.Apellido;
                context.Edad = modelo.Edad;
                context.Documento = modelo.Documento;
                context.IdUsuario = modelo.IdUsuario;
            }
        }
    }
}