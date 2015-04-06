/*
 * Created by Ranorex
 * User: gguenther
 * Date: 7/28/2011
 * Time: 10:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace CommonUtilLib
{
    /// <summary>
    /// Description of StreamTcpClient.
    /// </summary>
    /// 

    

//    public class Server
//    {
//    	private TcpListener tcpListener;
//    	private Thread listenThread;
//    	
//    	public Server(int port)
//    	{
//    		this.tcpListener = new TcpListener(IPAddress.Any, port);
//    		this.listenThread = new Thread(new ThreadStart(ListenForClients));
//    		this.listenThread.Start();
//    	}
//    	
//    	public void ListenForClients()
//    	{
//    		this.tcpListener.Start();
//    		
//    		while (true)
//    		{
//    			//blocks until a client has connected to the server
//    			TcpClient client = this.tcpListener.AcceptTcpClient();
//    			
//    			//create a thread to handle communication
//    			//with connected client
//    			Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
//    			clientThread.Start(client);
//    		}
//    	}
//    	
//    	public void HandleClientComm(object client)
//    	{
//    		TcpClient tcpClient = (TcpClient)client;
//    		NetworkStream clientStream = tcpClient.GetStream();
//    		
//    		byte[] message = new byte[4096];
//    		int bytesRead;
//    		
//    		while (true)
//    		{
//    			bytesRead = 0;
//    			
//    			try 
//    			{
//    				//blocks until a client sends a message
//    				bytesRead = clientStream.Read(message, 0, 4096);
//    			}
//    			
//    			catch
//    			{
//    				//a socket error has occured
//    				Report.Error("A socket error has occured");
//    				break;
//    			}
//    			
//    			if (bytesRead == 0)
//    			{
//    				//the client has disconnected from the server
//    				Report.Info("The client " + client " has disconnected from the server");
//    				break;
//    			}
//    			
//    			//message has successfully been received
//    			ASCIIEncoding encoder = new ASCIIEncoding();
//    			System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead);   
//    			  
//    			                                   
//    			NetworkStream clientStream = tcpClient.GetStream();
//    			ASCIIEncoding encoder = new ASCIIEncoding();
//    			byte[] Buffer = encoder.GetBytes("Hello Client");
//    			
//    			clientStream.Write(Buffer, 0, Buffer.Length);
//    			clientStream.Flush();
//                                  
//    			
//    		}
//    		
//    		tcpClient.Close();
//    	}
//    }
//    	
//    	
//    public class Client
//    	
//    	{
//    		public void Connect(string IP, int port)
//    		{
//    			TcpClient client = new TcpClient();
//    			
//    			IPEndPoint serverEndPoint = new IPEndPoint(IP, port);
//    			
//    			client.Connect(serverEndPoint);
//    			
//    		}
//    		
//    		public void 
//    			
//    			NetworkStream clientStream = client.GetStream();
//    			
//    			ASCIIEncoding encoder = new ASCIIEncoding();
//    			byte[] buffer = encoder.GetBytes("Hello Server!");
//    			
//    			clientStream.Write(buffer, 0, buffer.Length);
//    			clientStream.Flush();
//
//    		}
//    	}
//    	
//}
    	
    	
    	
//    	public static string currentstate;
//      	string data = "";
//	    string input = "";
//	    
//      
//	    public void Connect(int port)
//		{
//	    
//		IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);
//			
//		Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//			
//		newsock.Bind(ipep);
//		newsock.Listen(10);
//		Report.Info("Waiting for a client to connect...");
//			
//		Socket client = newsock.Accept();
//		IPEndPoint newclient = (IPEndPoint)client.RemoteEndPoint;
//		Report.Info("Connected with " + newclient.Address + " on port " + newclient.Port);
//		
//		NetworkStream ns = new NetworkStream(client);
//		StreamReader sr = new StreamReader(ns);
//		StreamWriter sw = new StreamWriter(ns);
//		
//		string welcome = "Welcome";
//		sw.WriteLine(welcome);
//		sw.Flush();
//		
//		while (true)
//			{
//			data = sr.ReadLine();
//			Report.Info(data);
//			sw.WriteLine(data);
//			sw.Flush();
//			}
//		
//	    }
	    
//	    public void SendMessage(string message)
//		{    	
//		    sw.WriteLine(currentstate);
//		    sw.Flush();
//		    data = sr.ReadLine();
//		}
		    
//		public void CloseConnection()
//		{
//		    Console.WriteLine("Disconnected from {0}", newclient.Address);
//	      	sw.Close();
//	      	sr.Close();
//	      	ns.Close();
//	      	newso.stop();
//		}
		
//		
//		
//		
//			
//		NetworkStream ns = new NetworkStream(client);
//		StreamReader sr = new StreamReader(ns);
//		StreamWriter sw = new StreamWriter(ns);
//
//		sw.WriteLine(input);
//		sw.Flush();
//		string datatmp = sr.ReadLine();
//		TestState();
//		}
//	    
//		public void TestState()
//		{
//		
//		while (data != datatmp)
//			{
//				switch(datatmp)
//				{
//					case "0":
//					Report.Info("Remote script is ready");
//					break;
//						
//					case "1":
//					Report.Info("Message creation in progress");
//					CommonUtilLib.Forms.AwaitingDataForm ADform = new CommonUtilLib.Forms.AwaitingDataForm();
//					Application.Run(ADform);
//					break;
//							
//					case "2":
//					Report.Info("Message creation complete");
//					break;
//						
//					case "3":
//					Report.Info("Message validation started");
//					CommonUtilLib.Forms.AwaitingValidationForm AVform = new CommonUtilLib.Forms.AwaitingValidationForm();
//					Application.Run(AVform);
//					break;
//						
//					case "4":
//					Report.Info("Message validation complete");
//					break;
//						
//					case "5":
//					Report.Info("Test Suite Complete, closing connections");
//					break;
//							
//					default:
//					Report.Error("Valid status not received from remote script");
//					break;
//				}	
//				
//			data = datatmp;
//			}
//		}
		
		
//		Report.Info("Disconnected from " + newclient.Address);
//		sw.Close();
//		sr.Close();
//		ns.Close();
	    

	    
//	    public class Client
//	    {
//	    	public static string currentstate;
//	    	
//	    	private static TcpClient tcpclient = null;
//	    	private static NetworkStream ns = null;
//	    	private static StreamReader reader = null;
//	    	private static StreamWriter writer = null;
//	    	
//	    	private static Client client = new Client();
//	    	
//	    	public Client()
//	    	{
//	    		
//	    	}
//	    	
//	    	//Singleton - only need 1 client
//	    	public static Client getInstance()
//	    	{
//	    		return client;
//	    	}
//	    	
//	    	//connect once here
//	    	public void Connect(string ip, int port)
//	    	{
//	    		try
//	    		{
//	    			tcpclient = new TcpClient(ip, port);
//	    			Report.Info("Successfully Connected to " + ip + " on port " + port);
//	    			ns = tcpclient.GetStream();
//	    			writer = new StreamWriter(ns);
//	    		}
//	    		catch (Exception e)
//	    		{
//	    			Report.Info(e.Message);
//	    		}
//	    		
//	    		
//	    	}
//	    	
//	    	public void SendMessage(string message)
//		    {    	
//	    		writer.WriteLine(message);
//	    		writer.Flush();
//		    }
//		    	
//	    	public void CloseConnection()
//	    	{
//	    		reader.Close();
//	    		writer.Close();
//	    		ns.Close();
//	    		tcpclient.Close();
//	    	}
	    }
	    
	    
   
	    
	    
	    
//	    public class Client(string ip, int port)
//		{
//
//	   	IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
//			
//		Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//		
//		try
//			{
//			server.Connect(ipep);
//			} 
//			      
//		catch (SocketException e)
//			{
//			Report.Info("Unable to connect to server.");
//			Report.Info(e.ToString());
//			return;
//			}
//		      
//		Report.Info("Successfully Connected to " + ip);
//		
//	    }
		
//		NetworkStream ns = new NetworkStream(server);
//		StreamReader sr = new StreamReader(ns);
//		StreamWriter sw = new StreamWriter(ns);
//
//		sw.WriteLine(currentstate);
//		sw.Flush();
//		data = sr.ReadLine();
//		