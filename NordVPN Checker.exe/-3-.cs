using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ?1?
{
	// Token: 0x02000006 RID: 6
	internal class ?3?
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002EA8 File Offset: 0x000010A8
		public static string ?11?(string ?20?, string ?21?, string ?22?, bool ?23? = false, bool ?24? = false)
		{
			string text = ?20?;
			List<string> list = new List<string>();
			bool flag = ((!(?21? == "")) ? 0 : ((?22? == "") ? 1 : 0)) != 0;
			string result;
			if (flag)
			{
				result = ?20?;
			}
			else
			{
				int num;
				if (!text.Contains(?21?))
				{
					if (?21? != "")
					{
						num = 1;
						goto IL_114;
					}
				}
				num = (text.Contains(?22?) ? 0 : ((?22? != "") ? 1 : 0));
				IL_114:
				bool flag2 = num != 0;
				if (flag2)
				{
					result = "";
				}
				else
				{
					string text2 = null;
					if (?23?)
					{
						if (?24?)
						{
							try
							{
								string pattern = ?3?.?12?(?21?, ?22?);
								foreach (object obj in Regex.Matches(text, pattern))
								{
									Capture capture = (Capture)obj;
									text2 = capture.Value;
								}
								result = text2;
							}
							catch
							{
								result = text2;
							}
						}
						else
						{
							try
							{
								for (;;)
								{
									if (text.Contains(?21?))
									{
										goto IL_307;
									}
									if (?21? == "")
									{
										goto IL_307;
									}
									int num2 = 0;
									IL_358:
									if (num2 == 0)
									{
										break;
									}
									int startIndex = (?21? == "") ? 0 : (text.IndexOf(?21?) + ?21?.Length);
									string text3 = text.Substring(startIndex);
									int length = (?22? == "") ? (text3.Length - 1) : text3.IndexOf(?22?);
									text2 = text3.Substring(0, length);
									text = text3.Substring(text2.Length + ?22?.Length);
									continue;
									IL_307:
									num2 = (text.Contains(?22?) ? 1 : ((?22? == "") ? 1 : 0));
									goto IL_358;
								}
								result = text2;
							}
							catch
							{
								result = text2;
							}
						}
					}
					else
					{
						if (?24?)
						{
							string pattern2 = ?3?.?12?(?21?, ?22?);
							MatchCollection matchCollection = Regex.Matches(text, pattern2);
							bool flag3 = matchCollection.Count > 0;
							if (flag3)
							{
								text2 = matchCollection[0].Value;
							}
						}
						else
						{
							try
							{
								int startIndex2 = (?21? == "") ? 0 : (text.IndexOf(?21?) + ?21?.Length);
								string text4 = text.Substring(startIndex2);
								int length2 = (?22? == "") ? text4.Length : text4.IndexOf(?22?);
								text2 = text4.Substring(0, length2);
							}
							catch
							{
							}
						}
						result = text2;
					}
				}
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000033C8 File Offset: 0x000015C8
		public static string ?12?(string ?25?, string ?26?)
		{
			return string.Concat(new string[]
			{
				"(?<=",
				string.IsNullOrEmpty(?25?) ? "^" : Regex.Escape(?25?),
				").+?(?=",
				string.IsNullOrEmpty(?26?) ? "$" : Regex.Escape(?26?),
				")"
			});
		}
	}
}
