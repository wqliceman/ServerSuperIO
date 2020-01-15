using System;
using System.IO;

namespace ServerSuperIO.Common.Assembly
{
    /// <summary>
    /// һ������ IObjectBuilder ʵ��
    /// </summary>
    public class TypeCreator : IObjectBuilder
    {
        public T BuildUp<T>() where T : new()
        {
            return Activator.CreateInstance<T>();
        }

        public T BuildUp<T>(string typeName)
        {
            return (T)Activator.CreateInstance(Type.GetType(typeName));
        }

        public T BuildUp<T>(object[] args)
        {
            object result = Activator.CreateInstance(typeof(T), args);
            return (T)result;
        }

        /// <summary>
        /// ���ƽ̨��Ҫʹ�������������
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assemblyname"></param>
        /// <param name="instancename"></param>
        /// <returns></returns>
        public T BuildUp<T>(string assemblyname, string instancename)
        {
            if (!System.IO.File.Exists(assemblyname))
            {
                throw new FileNotFoundException(assemblyname + " ������");
            }
            System.Reflection.Assembly assmble = System.Reflection.Assembly.LoadFrom(assemblyname);
            object tmpobj = assmble.CreateInstance(instancename);
            return (T)tmpobj;
        }

        public T BuildUp<T>(string typeName, object[] args)
        {
            object result = Activator.CreateInstance(Type.GetType(typeName), args);
            return (T)result;
        }
    }
}