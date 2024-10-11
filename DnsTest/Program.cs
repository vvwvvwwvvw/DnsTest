
//// 호스트/도메인 명에서 IP 알아내기

using System.Net;

/// 인터넷 호스트명 정보 얻기
IPHostEntry hostEntry = Dns.GetHostEntry("www.naver.com");

Console.WriteLine(hostEntry.HostName);
foreach (IPAddress ip in hostEntry.AddressList)
{
    Console.WriteLine(ip);
}

로컬 호스트명 정보 얻기

string hostname = Dns.GetHostName();
IPHostEntry localhost = Dns.GetHostEntry(hostname);

// IP 에서 호스트명 알아내기
IPAddress ipaddr = IPAddress.Parse("223.130.200.219");
IPHostEntry iPHostEntry = Dns.GetHostEntry(ipaddr);
Console.WriteLine(iPHostEntry.HostName);

// EndPoint 클래스

IPAddress ip1 = IPAddress.Parse("74.125.28.99");
IPEndPoint ep = new IPEndPoint(ip1, 80);

Console.WriteLine(ep.ToString()); // "74.125.28.99:80" 출력