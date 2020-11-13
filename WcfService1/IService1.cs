using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetIdBiblioteca(int value);

        [OperationContract]
        Libro GetLibro(Libro libro);

        [OperationContract]
        string GetIdProducto(int value);

        [OperationContract]
        Producto GetProducto(Producto producto);


        [OperationContract]
        Alumnos CrearAlumnos();

        [OperationContract]
        double convertirDolares(double pesos);

        [OperationContract]
        Alumnos GetDatosAlumnos(Alumnos alumnos);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }

    [DataContract]
    public class Alumnos
    {
        string nombre;
        int nocontrol;
        int semestre;
        float promedio;

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public int NoControl
        {
            get { return nocontrol; }
            set { nocontrol = value; }
        }
        [DataMember]
        public int Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        [DataMember]
        public float Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }
    }



    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    [DataContract]
    public class Producto
    {
        string nombre;
        int id;

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
    [DataContract]
    public class Libro
    {
        string titulo;
        int año;
        string autor;
        int id;

        [DataMember]
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        [DataMember]
        public int Año
        {
            get { return año; }
            set { año = value; }

        }
        [DataMember]
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}