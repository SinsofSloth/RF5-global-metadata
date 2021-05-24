[Serializable]
public class Match : Group // TypeDefIndex: 1784
{
	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x38
	internal Regex _regex; // 0x40
	internal int _textbeg; // 0x48
	internal int _textpos; // 0x4C
	internal int _textend; // 0x50
	internal int _textstart; // 0x54
	internal int[][] _matches; // 0x58
	internal int[] _matchcount; // 0x60
	internal bool _balancing; // 0x68

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x171C580 Offset: 0x171C681 VA: 0x171C580
	public static Match get_Empty() { }

	// RVA: 0x171C5F0 Offset: 0x171C6F1 VA: 0x171C5F0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x171C7C0 Offset: 0x171C8C1 VA: 0x171C7C0 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x171C870 Offset: 0x171C971 VA: 0x171C870 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x171C930 Offset: 0x171CA31 VA: 0x171C930
	public Match NextMatch() { }

	// RVA: 0x171CC40 Offset: 0x171CD41 VA: 0x171CC40 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x171CD40 Offset: 0x171CE41 VA: 0x171CD40
	internal string LastGroupToStringImpl() { }

	// RVA: 0x171CD70 Offset: 0x171CE71 VA: 0x171CD70 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x171CFF0 Offset: 0x171D0F1 VA: 0x171CFF0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x171D0E0 Offset: 0x171D1E1 VA: 0x171D0E0 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x171D130 Offset: 0x171D231 VA: 0x171D130 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x171D1E0 Offset: 0x171D2E1 VA: 0x171D1E0 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x171D280 Offset: 0x171D381 VA: 0x171D280 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x171D320 Offset: 0x171D421 VA: 0x171D320 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x171D4E0 Offset: 0x171D5E1 VA: 0x171D4E0
	private static void .cctor() { }

	// RVA: 0x171D580 Offset: 0x171D681 VA: 0x171D580
	internal void .ctor() { }
}

[Serializable]
public class Match : Group // TypeDefIndex: 1784
{
	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x38
	internal Regex _regex; // 0x40
	internal int _textbeg; // 0x48
	internal int _textpos; // 0x4C
	internal int _textend; // 0x50
	internal int _textstart; // 0x54
	internal int[][] _matches; // 0x58
	internal int[] _matchcount; // 0x60
	internal bool _balancing; // 0x68

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x171C580 Offset: 0x171C681 VA: 0x171C580
	public static Match get_Empty() { }

	// RVA: 0x171C5F0 Offset: 0x171C6F1 VA: 0x171C5F0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x171C7C0 Offset: 0x171C8C1 VA: 0x171C7C0 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x171C870 Offset: 0x171C971 VA: 0x171C870 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x171C930 Offset: 0x171CA31 VA: 0x171C930
	public Match NextMatch() { }

	// RVA: 0x171CC40 Offset: 0x171CD41 VA: 0x171CC40 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x171CD40 Offset: 0x171CE41 VA: 0x171CD40
	internal string LastGroupToStringImpl() { }

	// RVA: 0x171CD70 Offset: 0x171CE71 VA: 0x171CD70 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x171CFF0 Offset: 0x171D0F1 VA: 0x171CFF0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x171D0E0 Offset: 0x171D1E1 VA: 0x171D0E0 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x171D130 Offset: 0x171D231 VA: 0x171D130 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x171D1E0 Offset: 0x171D2E1 VA: 0x171D1E0 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x171D280 Offset: 0x171D381 VA: 0x171D280 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x171D320 Offset: 0x171D421 VA: 0x171D320 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x171D4E0 Offset: 0x171D5E1 VA: 0x171D4E0
	private static void .cctor() { }

	// RVA: 0x171D580 Offset: 0x171D681 VA: 0x171D580
	internal void .ctor() { }
}

[Serializable]
public class Match : Group // TypeDefIndex: 1784
{
	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x38
	internal Regex _regex; // 0x40
	internal int _textbeg; // 0x48
	internal int _textpos; // 0x4C
	internal int _textend; // 0x50
	internal int _textstart; // 0x54
	internal int[][] _matches; // 0x58
	internal int[] _matchcount; // 0x60
	internal bool _balancing; // 0x68

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x171C580 Offset: 0x171C681 VA: 0x171C580
	public static Match get_Empty() { }

	// RVA: 0x171C5F0 Offset: 0x171C6F1 VA: 0x171C5F0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x171C7C0 Offset: 0x171C8C1 VA: 0x171C7C0 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x171C870 Offset: 0x171C971 VA: 0x171C870 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x171C930 Offset: 0x171CA31 VA: 0x171C930
	public Match NextMatch() { }

	// RVA: 0x171CC40 Offset: 0x171CD41 VA: 0x171CC40 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x171CD40 Offset: 0x171CE41 VA: 0x171CD40
	internal string LastGroupToStringImpl() { }

	// RVA: 0x171CD70 Offset: 0x171CE71 VA: 0x171CD70 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x171CFF0 Offset: 0x171D0F1 VA: 0x171CFF0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x171D0E0 Offset: 0x171D1E1 VA: 0x171D0E0 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x171D130 Offset: 0x171D231 VA: 0x171D130 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x171D1E0 Offset: 0x171D2E1 VA: 0x171D1E0 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x171D280 Offset: 0x171D381 VA: 0x171D280 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x171D320 Offset: 0x171D421 VA: 0x171D320 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x171D4E0 Offset: 0x171D5E1 VA: 0x171D4E0
	private static void .cctor() { }

	// RVA: 0x171D580 Offset: 0x171D681 VA: 0x171D580
	internal void .ctor() { }
}

[Serializable]
public class Match : Group // TypeDefIndex: 1784
{
	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x38
	internal Regex _regex; // 0x40
	internal int _textbeg; // 0x48
	internal int _textpos; // 0x4C
	internal int _textend; // 0x50
	internal int _textstart; // 0x54
	internal int[][] _matches; // 0x58
	internal int[] _matchcount; // 0x60
	internal bool _balancing; // 0x68

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x171C580 Offset: 0x171C681 VA: 0x171C580
	public static Match get_Empty() { }

	// RVA: 0x171C5F0 Offset: 0x171C6F1 VA: 0x171C5F0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x171C7C0 Offset: 0x171C8C1 VA: 0x171C7C0 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x171C870 Offset: 0x171C971 VA: 0x171C870 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x171C930 Offset: 0x171CA31 VA: 0x171C930
	public Match NextMatch() { }

	// RVA: 0x171CC40 Offset: 0x171CD41 VA: 0x171CC40 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x171CD40 Offset: 0x171CE41 VA: 0x171CD40
	internal string LastGroupToStringImpl() { }

	// RVA: 0x171CD70 Offset: 0x171CE71 VA: 0x171CD70 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x171CFF0 Offset: 0x171D0F1 VA: 0x171CFF0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x171D0E0 Offset: 0x171D1E1 VA: 0x171D0E0 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x171D130 Offset: 0x171D231 VA: 0x171D130 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x171D1E0 Offset: 0x171D2E1 VA: 0x171D1E0 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x171D280 Offset: 0x171D381 VA: 0x171D280 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x171D320 Offset: 0x171D421 VA: 0x171D320 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x171D4E0 Offset: 0x171D5E1 VA: 0x171D4E0
	private static void .cctor() { }

	// RVA: 0x171D580 Offset: 0x171D681 VA: 0x171D580
	internal void .ctor() { }
}

[Serializable]
public class Match : Group // TypeDefIndex: 1784
{
	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x38
	internal Regex _regex; // 0x40
	internal int _textbeg; // 0x48
	internal int _textpos; // 0x4C
	internal int _textend; // 0x50
	internal int _textstart; // 0x54
	internal int[][] _matches; // 0x58
	internal int[] _matchcount; // 0x60
	internal bool _balancing; // 0x68

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x171C580 Offset: 0x171C681 VA: 0x171C580
	public static Match get_Empty() { }

	// RVA: 0x171C5F0 Offset: 0x171C6F1 VA: 0x171C5F0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x171C7C0 Offset: 0x171C8C1 VA: 0x171C7C0 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x171C870 Offset: 0x171C971 VA: 0x171C870 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x171C930 Offset: 0x171CA31 VA: 0x171C930
	public Match NextMatch() { }

	// RVA: 0x171CC40 Offset: 0x171CD41 VA: 0x171CC40 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x171CD40 Offset: 0x171CE41 VA: 0x171CD40
	internal string LastGroupToStringImpl() { }

	// RVA: 0x171CD70 Offset: 0x171CE71 VA: 0x171CD70 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x171CFF0 Offset: 0x171D0F1 VA: 0x171CFF0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x171D0E0 Offset: 0x171D1E1 VA: 0x171D0E0 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x171D130 Offset: 0x171D231 VA: 0x171D130 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x171D1E0 Offset: 0x171D2E1 VA: 0x171D1E0 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x171D280 Offset: 0x171D381 VA: 0x171D280 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x171D320 Offset: 0x171D421 VA: 0x171D320 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x171D4E0 Offset: 0x171D5E1 VA: 0x171D4E0
	private static void .cctor() { }

	// RVA: 0x171D580 Offset: 0x171D681 VA: 0x171D580
	internal void .ctor() { }
}

[Serializable]
public class Match : Group // TypeDefIndex: 1784
{
	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x38
	internal Regex _regex; // 0x40
	internal int _textbeg; // 0x48
	internal int _textpos; // 0x4C
	internal int _textend; // 0x50
	internal int _textstart; // 0x54
	internal int[][] _matches; // 0x58
	internal int[] _matchcount; // 0x60
	internal bool _balancing; // 0x68

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x171C580 Offset: 0x171C681 VA: 0x171C580
	public static Match get_Empty() { }

	// RVA: 0x171C5F0 Offset: 0x171C6F1 VA: 0x171C5F0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x171C7C0 Offset: 0x171C8C1 VA: 0x171C7C0 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x171C870 Offset: 0x171C971 VA: 0x171C870 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x171C930 Offset: 0x171CA31 VA: 0x171C930
	public Match NextMatch() { }

	// RVA: 0x171CC40 Offset: 0x171CD41 VA: 0x171CC40 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x171CD40 Offset: 0x171CE41 VA: 0x171CD40
	internal string LastGroupToStringImpl() { }

	// RVA: 0x171CD70 Offset: 0x171CE71 VA: 0x171CD70 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x171CFF0 Offset: 0x171D0F1 VA: 0x171CFF0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x171D0E0 Offset: 0x171D1E1 VA: 0x171D0E0 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x171D130 Offset: 0x171D231 VA: 0x171D130 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x171D1E0 Offset: 0x171D2E1 VA: 0x171D1E0 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x171D280 Offset: 0x171D381 VA: 0x171D280 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x171D320 Offset: 0x171D421 VA: 0x171D320 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x171D4E0 Offset: 0x171D5E1 VA: 0x171D4E0
	private static void .cctor() { }

	// RVA: 0x171D580 Offset: 0x171D681 VA: 0x171D580
	internal void .ctor() { }
}

[Serializable]
public class Match : Group // TypeDefIndex: 1784
{
	// Fields
	internal static Match _empty; // 0x0
	internal GroupCollection _groupcoll; // 0x38
	internal Regex _regex; // 0x40
	internal int _textbeg; // 0x48
	internal int _textpos; // 0x4C
	internal int _textend; // 0x50
	internal int _textstart; // 0x54
	internal int[][] _matches; // 0x58
	internal int[] _matchcount; // 0x60
	internal bool _balancing; // 0x68

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x171C580 Offset: 0x171C681 VA: 0x171C580
	public static Match get_Empty() { }

	// RVA: 0x171C5F0 Offset: 0x171C6F1 VA: 0x171C5F0
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x171C7C0 Offset: 0x171C8C1 VA: 0x171C7C0 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x171C870 Offset: 0x171C971 VA: 0x171C870 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x171C930 Offset: 0x171CA31 VA: 0x171C930
	public Match NextMatch() { }

	// RVA: 0x171CC40 Offset: 0x171CD41 VA: 0x171CC40 Slot: 6
	internal virtual string GroupToStringImpl(int groupnum) { }

	// RVA: 0x171CD40 Offset: 0x171CE41 VA: 0x171CD40
	internal string LastGroupToStringImpl() { }

	// RVA: 0x171CD70 Offset: 0x171CE71 VA: 0x171CD70 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x171CFF0 Offset: 0x171D0F1 VA: 0x171CFF0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x171D0E0 Offset: 0x171D1E1 VA: 0x171D0E0 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x171D130 Offset: 0x171D231 VA: 0x171D130 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x171D1E0 Offset: 0x171D2E1 VA: 0x171D1E0 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x171D280 Offset: 0x171D381 VA: 0x171D280 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x171D320 Offset: 0x171D421 VA: 0x171D320 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x171D4E0 Offset: 0x171D5E1 VA: 0x171D4E0
	private static void .cctor() { }

	// RVA: 0x171D580 Offset: 0x171D681 VA: 0x171D580
	internal void .ctor() { }
}

