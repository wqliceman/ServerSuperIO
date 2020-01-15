namespace ServerSuperIO.Device
{
    /// <summary>
    /// ���������¼�
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    public delegate void SendDataHandler(object source, SendDataArgs e);

    /// <summary>
    /// �������м������¼�
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    public delegate void DeviceRuningLogHandler(object source, DeviceRuningLogArgs e);

    /// <summary>
    /// �ı䴮�ڲ���
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    public delegate void ComParameterExchangeHandler(object source, ComParameterExchangeArgs e);

    /// <summary>
    /// �豸��ʾ�����¼�
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    public delegate void DeviceObjectChangedHandler(object source, DeviceObjectChangedArgs e);

    /// <summary>
    /// ɾ���豸�¼�
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    public delegate void DeleteDeviceHandler(object source, DeleteDeviceArgs e);

    /// <summary>
    /// �����豸�������¼�
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    public delegate void UpdateContainerHandler(object source, UpdateContainerArgs e);
}