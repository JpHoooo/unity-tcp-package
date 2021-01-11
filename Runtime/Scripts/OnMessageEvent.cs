using System.Net;
using System.Net.Sockets;
using UnityEngine.Events;

namespace Jphoooo.Tcp
{

    [System.Serializable]
    public class OnMessageEvent : UnityEvent<string>
    {
    }

    [System.Serializable]
    public class OnEstablishedEvent : UnityEvent<TcpClient>
    {
    }

    [System.Serializable]
    public class OnDisconnectedEvent : UnityEvent<EndPoint>
    {
    }
}