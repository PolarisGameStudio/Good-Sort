using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class EnvelopeByLevelDifficultSheet
{
	public int diff;

	public EncryptedInt amount;

	private static Dictionary<int, EnvelopeByLevelDifficultSheet> dictionary;

	public static EnvelopeByLevelDifficultSheet Get(int diff)
	{
		return null;
	}

	public static Dictionary<int, EnvelopeByLevelDifficultSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, EnvelopeByLevelDifficultSheet> dic)
	{
	}
}
