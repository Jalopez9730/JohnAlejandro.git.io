using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LaboratorioASP.Recursos
{
    interface Ifunciones
    {
        int Registrar();
        bool Actualizar();
        bool Eliminar(int id);
        DataTable Listar();
        DataTable BuscarPorCodigo(int id);
    }
}
