
//// 호스트/도메인 명에서 IP 알아내기

using System.Net;

/// 인터넷 호스트명 정보 얻기
IPHostEntry hostEntry = Dns.GetHostEntry("www.naver.com");

Console.WriteLine(hostEntry.HostName);
foreach (IPAddress ip in hostEntry.AddressList)
{
    Console.WriteLine(ip);
}

// 로컬 호스트명 정보 얻기

string hostname = Dns.GetHostName();
IPHostEntry localhost = Dns.GetHostEntry(hostname);
