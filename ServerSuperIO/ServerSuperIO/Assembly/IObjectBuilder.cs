namespace ServerSuperIO.Common.Assembly
{
    /// <summary>
    /// ��������������������ʵ��
    /// </summary>
    public interface IObjectBuilder
    {
        /// <summary>
        /// ��������ʵ��
        /// </summary>
        /// <typeparam name="T">��������</typeparam>
        /// <param name="args">�������</param>
        /// <returns>ָ������ T ��ʵ��</returns>
        T BuildUp<T>(object[] args);

        /// <summary>
        /// ��������ʵ��
        /// <remarks>�÷��������������޲ι��캯���ĵ�����</remarks>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T BuildUp<T>() where T : new();

        /// <summary>
        /// ����Ŀ�귵�ص����ͣ��ӹ�ָ���������ƶ�Ӧ������ʵ����
        /// Ŀ�����Ϳ���Ϊ�ӿڡ�������ȳ������ͣ�typeNameһ��Ϊʵ�������ơ�
        /// </summary>
        /// <typeparam name="T">Ŀ�귵�ص����͡�</typeparam>
        /// <param name="typeName">��������<</param>
        /// <returns>����Ŀ�귵�����ͼӹ��õ�һ��ʵ��</returns>
        T BuildUp<T>(string typeName);

        /// <summary>
        /// ����Ŀ�����ͣ�ͨ������ָ���������͵Ĺ��캯��������Ŀ������ʵ����
        /// </summary>
        /// <typeparam name="T">Ŀ�귵�ص�����</typeparam>
        /// <param name="typeName">��������</param>
        /// <param name="args">���캯������</param>
        /// <returns>����Ŀ�귵�����ͼӹ��õ�һ��ʵ��</returns>
        T BuildUp<T>(string typeName, object[] args);

        /// <summary>
        /// ָ���������ƺ�ʵ�������ƣ���̬����ʵ��
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assemblyname"></param>
        /// <param name="instancename"></param>
        /// <returns></returns>
        T BuildUp<T>(string assemblyname, string instancename);
    }
}