using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMXamarin.Models
{
    public class Usuario : INotifyPropertyChanged
    {

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        //Atributos
        private string idUsuario;
        private string nombre;
        private string apellido;
        private string nombreCompleto;
        private long documento;
        private int edad;
        private string mensaje;
        private bool isBusy = false;

        //Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        //Métodos

        public string IdUsuario
        {
            get { return idUsuario; }
            set
            {
                idUsuario = value;
                OnPropertyChanged();
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set {
                nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                edad = value;
                OnPropertyChanged();
            }
        }

        public long Documento
        {
            get { return documento; }
            set
            {
                documento = value;
                OnPropertyChanged();
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
            set
            {
                nombreCompleto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Mensaje));
            }
        }

        public string Mensaje
        {
            get
            {
                return $"Bienvenido, {NombreCompleto}";
            }
            
        }

        public bool IsBusy
        {
            get { return isBusy=false; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName]string nombre="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
