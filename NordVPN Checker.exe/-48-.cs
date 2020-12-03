using System;

// Token: 0x02000007 RID: 7
public class ?48?
{
	// Token: 0x06000011 RID: 17 RVA: 0x00003460 File Offset: 0x00001660
	public static string ?49?(string ?49?)
	{
		int length = ?49?.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = ?49?[i];
			byte b = (byte)((int)c ^ length - i);
			byte b2 = (byte)((int)(c >> 8) ^ i);
			array[i] = (char)((int)b2 << 8 | (int)b);
		}
		return string.Intern(new string(array));
	}
}
