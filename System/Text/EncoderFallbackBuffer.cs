public abstract class EncoderFallbackBuffer // TypeDefIndex: 461
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining() { }

	// RVA: 0x2A76790 Offset: 0x2A76891 VA: 0x2A76790 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x2A767D0 Offset: 0x2A768D1 VA: 0x2A767D0
	internal void InternalReset() { }

	// RVA: 0x2A720E0 Offset: 0x2A721E1 VA: 0x2A720E0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x2A72130 Offset: 0x2A72231 VA: 0x2A72130
	internal char InternalGetNextChar() { }

	// RVA: 0x2A767F0 Offset: 0x2A768F1 VA: 0x2A767F0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x2A769F0 Offset: 0x2A76AF1 VA: 0x2A769F0
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x2A75D20 Offset: 0x2A75E21 VA: 0x2A75D20
	protected void .ctor() { }
}

public abstract class EncoderFallbackBuffer // TypeDefIndex: 461
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining() { }

	// RVA: 0x2A76790 Offset: 0x2A76891 VA: 0x2A76790 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x2A767D0 Offset: 0x2A768D1 VA: 0x2A767D0
	internal void InternalReset() { }

	// RVA: 0x2A720E0 Offset: 0x2A721E1 VA: 0x2A720E0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x2A72130 Offset: 0x2A72231 VA: 0x2A72130
	internal char InternalGetNextChar() { }

	// RVA: 0x2A767F0 Offset: 0x2A768F1 VA: 0x2A767F0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x2A769F0 Offset: 0x2A76AF1 VA: 0x2A769F0
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x2A75D20 Offset: 0x2A75E21 VA: 0x2A75D20
	protected void .ctor() { }
}

public abstract class EncoderFallbackBuffer // TypeDefIndex: 461
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining() { }

	// RVA: 0x2A76790 Offset: 0x2A76891 VA: 0x2A76790 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x2A767D0 Offset: 0x2A768D1 VA: 0x2A767D0
	internal void InternalReset() { }

	// RVA: 0x2A720E0 Offset: 0x2A721E1 VA: 0x2A720E0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x2A72130 Offset: 0x2A72231 VA: 0x2A72130
	internal char InternalGetNextChar() { }

	// RVA: 0x2A767F0 Offset: 0x2A768F1 VA: 0x2A767F0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x2A769F0 Offset: 0x2A76AF1 VA: 0x2A769F0
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x2A75D20 Offset: 0x2A75E21 VA: 0x2A75D20
	protected void .ctor() { }
}

public abstract class EncoderFallbackBuffer // TypeDefIndex: 461
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining() { }

	// RVA: 0x2A76790 Offset: 0x2A76891 VA: 0x2A76790 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x2A767D0 Offset: 0x2A768D1 VA: 0x2A767D0
	internal void InternalReset() { }

	// RVA: 0x2A720E0 Offset: 0x2A721E1 VA: 0x2A720E0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x2A72130 Offset: 0x2A72231 VA: 0x2A72130
	internal char InternalGetNextChar() { }

	// RVA: 0x2A767F0 Offset: 0x2A768F1 VA: 0x2A767F0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x2A769F0 Offset: 0x2A76AF1 VA: 0x2A769F0
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x2A75D20 Offset: 0x2A75E21 VA: 0x2A75D20
	protected void .ctor() { }
}

public abstract class EncoderFallbackBuffer // TypeDefIndex: 461
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining() { }

	// RVA: 0x2A76790 Offset: 0x2A76891 VA: 0x2A76790 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x2A767D0 Offset: 0x2A768D1 VA: 0x2A767D0
	internal void InternalReset() { }

	// RVA: 0x2A720E0 Offset: 0x2A721E1 VA: 0x2A720E0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x2A72130 Offset: 0x2A72231 VA: 0x2A72130
	internal char InternalGetNextChar() { }

	// RVA: 0x2A767F0 Offset: 0x2A768F1 VA: 0x2A767F0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x2A769F0 Offset: 0x2A76AF1 VA: 0x2A769F0
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x2A75D20 Offset: 0x2A75E21 VA: 0x2A75D20
	protected void .ctor() { }
}

public abstract class EncoderFallbackBuffer // TypeDefIndex: 461
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining() { }

	// RVA: 0x2A76790 Offset: 0x2A76891 VA: 0x2A76790 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x2A767D0 Offset: 0x2A768D1 VA: 0x2A767D0
	internal void InternalReset() { }

	// RVA: 0x2A720E0 Offset: 0x2A721E1 VA: 0x2A720E0
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x2A72130 Offset: 0x2A72231 VA: 0x2A72130
	internal char InternalGetNextChar() { }

	// RVA: 0x2A767F0 Offset: 0x2A768F1 VA: 0x2A767F0 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x2A769F0 Offset: 0x2A76AF1 VA: 0x2A769F0
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x2A75D20 Offset: 0x2A75E21 VA: 0x2A75D20
	protected void .ctor() { }
}

