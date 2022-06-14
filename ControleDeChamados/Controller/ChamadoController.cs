using ControleDeChamados.DAO;
using ControleDeChamados.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeChamados.Controller
{
    public class ChamadoController
    {
        public Chamado CalcularNumeroChamado()
        {
            return new ChamadoDB().CalcularNumeroChamado();
        }
    }
}
