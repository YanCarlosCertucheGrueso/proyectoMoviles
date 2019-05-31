using MVVMXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;

namespace MVVMXamarin.Services
{
    public class UserServices
    {
        //Atributos
        public ObservableCollection<Usuario> usuarios { get; set; }

        //Constructor

        public UserServices()
        {
            if (usuarios == null)
            {
                usuarios = new ObservableCollection<Usuario>();
            }
        }
        //Métodos

        public ObservableCollection<Usuario> Consultar()
        {
            return usuarios;
        }

        public void Guardar(Usuario modelo)
        {
            usuarios.Add(modelo);
        }

        public void Modificar(Usuario modelo)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].IdUsuario == modelo.IdUsuario)
                {
                    usuarios[i] = modelo;
                }
            }
        }

        public void Eliminar(string idUsuario)
        {
            Usuario modelo = usuarios.FirstOrDefault(p => p.IdUsuario == idUsuario);
            usuarios.Remove(modelo);
        }

    }
}
