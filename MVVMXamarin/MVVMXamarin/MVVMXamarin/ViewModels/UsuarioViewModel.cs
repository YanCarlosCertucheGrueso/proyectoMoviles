using MVVMXamarin.Models;
using MVVMXamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMXamarin.ViewModels
{
    public class UsuarioViewModel : Usuario
    {
        //Atributos
        private ObservableCollection<Usuario> usuarios;
        UserServices servicio = new UserServices();
        Usuario usuario;

        //Constructor
        public UsuarioViewModel()
        {
            Usuarios = servicio.Consultar();
            GuardarCommand = new Command(async() => await Guardar(), () => !IsBusy);
            ModificarCommand = new Command(async () => await Modificar(), () => !IsBusy);
            EliminarCommand = new Command(async () => await Eliminar(), () => !IsBusy);
            LimpiarCommand = new Command(Limpiar, () => !IsBusy);
        }

        //Eventos
        public Command GuardarCommand { get; set; }
        public Command ModificarCommand { get; set; }
        public Command EliminarCommand { get; set; }
        public Command LimpiarCommand { get; set; }

        //Métodos

        public ObservableCollection<Usuario> Usuarios
        {
            get { return usuarios; }
            set
            {
                usuarios = value;
                OnPropertyChanged("Usuarios");
            }
        }


        private async Task Guardar()
        //private void Guardar()
        {
            IsBusy = true;
            Guid nuevoId = Guid.NewGuid();
            usuario = new Usuario()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Documento = Documento,
                IdUsuario = nuevoId.ToString()
            };
            servicio.Guardar(usuario);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private async Task Modificar()
        //private void Modificar()
        {
            IsBusy = true;
            usuario = new Usuario()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Edad = Edad,
                Documento = Documento,
                IdUsuario = IdUsuario
            };
            servicio.Modificar(usuario);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private async Task Eliminar()
        //private void Eliminar()
        {
            IsBusy = true;
            servicio.Eliminar(IdUsuario);
            Limpiar();
            await Task.Delay(2000);
            IsBusy = false;
        }

        private void Limpiar()
        {
            Nombre = "";
            Apellido = "";
            Edad = 0;
            Documento = 0;
            IdUsuario = "";
        }

    }
}
