public static class MemoryMarshal // TypeDefIndex: 4395
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CDE60 Offset: 0x22CDF61 VA: 0x22CDE60
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0x22CE060 Offset: 0x22CE161 VA: 0x22CE060
	|-MemoryMarshal.TryGetArray<char>
	|
	|-RVA: 0x22CE260 Offset: 0x22CE361 VA: 0x22CE260
	|-MemoryMarshal.TryGetArray<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetMemoryManager<T, TManager>(ReadOnlyMemory<T> memory, out TManager manager, out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CE460 Offset: 0x22CE561 VA: 0x22CE460
	|-MemoryMarshal.TryGetMemoryManager<byte, object>
	|
	|-RVA: 0x22CE550 Offset: 0x22CE651 VA: 0x22CE550
	|-MemoryMarshal.TryGetMemoryManager<char, object>
	|
	|-RVA: 0x22CE640 Offset: 0x22CE741 VA: 0x22CE640
	|-MemoryMarshal.TryGetMemoryManager<object, object>
	*/

	// RVA: 0x1B6A0E0 Offset: 0x1B6A1E1 VA: 0x1B6A0E0
	public static bool TryGetString(ReadOnlyMemory<char> memory, out string text, out int start, out int length) { }

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267810 Offset: 0x2267911 VA: 0x2267810
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267890 Offset: 0x2267991 VA: 0x2267890
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22677D0 Offset: 0x22678D1 VA: 0x22677D0
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267850 Offset: 0x2267951 VA: 0x2267850
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2562590 Offset: 0x2562691 VA: 0x2562590
	|-MemoryMarshal.Cast<double, byte>
	|
	|-RVA: 0x2562770 Offset: 0x2562871 VA: 0x2562770
	|-MemoryMarshal.Cast<int, byte>
	|
	|-RVA: 0x2562950 Offset: 0x2562A51 VA: 0x2562950
	|-MemoryMarshal.Cast<float, byte>
	|
	|-RVA: 0x2562B30 Offset: 0x2562C31 VA: 0x2562B30
	|-MemoryMarshal.Cast<Bounds, byte>
	|
	|-RVA: 0x2562D10 Offset: 0x2562E11 VA: 0x2562D10
	|-MemoryMarshal.Cast<Color, byte>
	|
	|-RVA: 0x2562EF0 Offset: 0x2562FF1 VA: 0x2562EF0
	|-MemoryMarshal.Cast<Quaternion, byte>
	|
	|-RVA: 0x25630D0 Offset: 0x25631D1 VA: 0x25630D0
	|-MemoryMarshal.Cast<Rect, byte>
	|
	|-RVA: 0x25632B0 Offset: 0x25633B1 VA: 0x25632B0
	|-MemoryMarshal.Cast<Vector2, byte>
	|
	|-RVA: 0x2563490 Offset: 0x2563591 VA: 0x2563490
	|-MemoryMarshal.Cast<Vector3, byte>
	|
	|-RVA: 0x2563670 Offset: 0x2563771 VA: 0x2563670
	|-MemoryMarshal.Cast<Vector4, byte>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(ReadOnlySpan<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25615B0 Offset: 0x25616B1 VA: 0x25615B0
	|-MemoryMarshal.Cast<byte, long>
	|
	|-RVA: 0x2561790 Offset: 0x2561891 VA: 0x2561790
	|-MemoryMarshal.Cast<byte, ushort>
	|
	|-RVA: 0x2561970 Offset: 0x2561A71 VA: 0x2561970
	|-MemoryMarshal.Cast<byte, uint>
	*/
}

public static class MemoryMarshal // TypeDefIndex: 4395
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CDE60 Offset: 0x22CDF61 VA: 0x22CDE60
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0x22CE060 Offset: 0x22CE161 VA: 0x22CE060
	|-MemoryMarshal.TryGetArray<char>
	|
	|-RVA: 0x22CE260 Offset: 0x22CE361 VA: 0x22CE260
	|-MemoryMarshal.TryGetArray<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetMemoryManager<T, TManager>(ReadOnlyMemory<T> memory, out TManager manager, out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CE460 Offset: 0x22CE561 VA: 0x22CE460
	|-MemoryMarshal.TryGetMemoryManager<byte, object>
	|
	|-RVA: 0x22CE550 Offset: 0x22CE651 VA: 0x22CE550
	|-MemoryMarshal.TryGetMemoryManager<char, object>
	|
	|-RVA: 0x22CE640 Offset: 0x22CE741 VA: 0x22CE640
	|-MemoryMarshal.TryGetMemoryManager<object, object>
	*/

	// RVA: 0x1B6A0E0 Offset: 0x1B6A1E1 VA: 0x1B6A0E0
	public static bool TryGetString(ReadOnlyMemory<char> memory, out string text, out int start, out int length) { }

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267810 Offset: 0x2267911 VA: 0x2267810
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267890 Offset: 0x2267991 VA: 0x2267890
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22677D0 Offset: 0x22678D1 VA: 0x22677D0
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267850 Offset: 0x2267951 VA: 0x2267850
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2562590 Offset: 0x2562691 VA: 0x2562590
	|-MemoryMarshal.Cast<double, byte>
	|
	|-RVA: 0x2562770 Offset: 0x2562871 VA: 0x2562770
	|-MemoryMarshal.Cast<int, byte>
	|
	|-RVA: 0x2562950 Offset: 0x2562A51 VA: 0x2562950
	|-MemoryMarshal.Cast<float, byte>
	|
	|-RVA: 0x2562B30 Offset: 0x2562C31 VA: 0x2562B30
	|-MemoryMarshal.Cast<Bounds, byte>
	|
	|-RVA: 0x2562D10 Offset: 0x2562E11 VA: 0x2562D10
	|-MemoryMarshal.Cast<Color, byte>
	|
	|-RVA: 0x2562EF0 Offset: 0x2562FF1 VA: 0x2562EF0
	|-MemoryMarshal.Cast<Quaternion, byte>
	|
	|-RVA: 0x25630D0 Offset: 0x25631D1 VA: 0x25630D0
	|-MemoryMarshal.Cast<Rect, byte>
	|
	|-RVA: 0x25632B0 Offset: 0x25633B1 VA: 0x25632B0
	|-MemoryMarshal.Cast<Vector2, byte>
	|
	|-RVA: 0x2563490 Offset: 0x2563591 VA: 0x2563490
	|-MemoryMarshal.Cast<Vector3, byte>
	|
	|-RVA: 0x2563670 Offset: 0x2563771 VA: 0x2563670
	|-MemoryMarshal.Cast<Vector4, byte>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(ReadOnlySpan<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25615B0 Offset: 0x25616B1 VA: 0x25615B0
	|-MemoryMarshal.Cast<byte, long>
	|
	|-RVA: 0x2561790 Offset: 0x2561891 VA: 0x2561790
	|-MemoryMarshal.Cast<byte, ushort>
	|
	|-RVA: 0x2561970 Offset: 0x2561A71 VA: 0x2561970
	|-MemoryMarshal.Cast<byte, uint>
	*/
}

public static class MemoryMarshal // TypeDefIndex: 4395
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CDE60 Offset: 0x22CDF61 VA: 0x22CDE60
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0x22CE060 Offset: 0x22CE161 VA: 0x22CE060
	|-MemoryMarshal.TryGetArray<char>
	|
	|-RVA: 0x22CE260 Offset: 0x22CE361 VA: 0x22CE260
	|-MemoryMarshal.TryGetArray<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetMemoryManager<T, TManager>(ReadOnlyMemory<T> memory, out TManager manager, out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CE460 Offset: 0x22CE561 VA: 0x22CE460
	|-MemoryMarshal.TryGetMemoryManager<byte, object>
	|
	|-RVA: 0x22CE550 Offset: 0x22CE651 VA: 0x22CE550
	|-MemoryMarshal.TryGetMemoryManager<char, object>
	|
	|-RVA: 0x22CE640 Offset: 0x22CE741 VA: 0x22CE640
	|-MemoryMarshal.TryGetMemoryManager<object, object>
	*/

	// RVA: 0x1B6A0E0 Offset: 0x1B6A1E1 VA: 0x1B6A0E0
	public static bool TryGetString(ReadOnlyMemory<char> memory, out string text, out int start, out int length) { }

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267810 Offset: 0x2267911 VA: 0x2267810
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267890 Offset: 0x2267991 VA: 0x2267890
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22677D0 Offset: 0x22678D1 VA: 0x22677D0
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267850 Offset: 0x2267951 VA: 0x2267850
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2562590 Offset: 0x2562691 VA: 0x2562590
	|-MemoryMarshal.Cast<double, byte>
	|
	|-RVA: 0x2562770 Offset: 0x2562871 VA: 0x2562770
	|-MemoryMarshal.Cast<int, byte>
	|
	|-RVA: 0x2562950 Offset: 0x2562A51 VA: 0x2562950
	|-MemoryMarshal.Cast<float, byte>
	|
	|-RVA: 0x2562B30 Offset: 0x2562C31 VA: 0x2562B30
	|-MemoryMarshal.Cast<Bounds, byte>
	|
	|-RVA: 0x2562D10 Offset: 0x2562E11 VA: 0x2562D10
	|-MemoryMarshal.Cast<Color, byte>
	|
	|-RVA: 0x2562EF0 Offset: 0x2562FF1 VA: 0x2562EF0
	|-MemoryMarshal.Cast<Quaternion, byte>
	|
	|-RVA: 0x25630D0 Offset: 0x25631D1 VA: 0x25630D0
	|-MemoryMarshal.Cast<Rect, byte>
	|
	|-RVA: 0x25632B0 Offset: 0x25633B1 VA: 0x25632B0
	|-MemoryMarshal.Cast<Vector2, byte>
	|
	|-RVA: 0x2563490 Offset: 0x2563591 VA: 0x2563490
	|-MemoryMarshal.Cast<Vector3, byte>
	|
	|-RVA: 0x2563670 Offset: 0x2563771 VA: 0x2563670
	|-MemoryMarshal.Cast<Vector4, byte>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(ReadOnlySpan<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25615B0 Offset: 0x25616B1 VA: 0x25615B0
	|-MemoryMarshal.Cast<byte, long>
	|
	|-RVA: 0x2561790 Offset: 0x2561891 VA: 0x2561790
	|-MemoryMarshal.Cast<byte, ushort>
	|
	|-RVA: 0x2561970 Offset: 0x2561A71 VA: 0x2561970
	|-MemoryMarshal.Cast<byte, uint>
	*/
}

public static class MemoryMarshal // TypeDefIndex: 4395
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CDE60 Offset: 0x22CDF61 VA: 0x22CDE60
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0x22CE060 Offset: 0x22CE161 VA: 0x22CE060
	|-MemoryMarshal.TryGetArray<char>
	|
	|-RVA: 0x22CE260 Offset: 0x22CE361 VA: 0x22CE260
	|-MemoryMarshal.TryGetArray<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetMemoryManager<T, TManager>(ReadOnlyMemory<T> memory, out TManager manager, out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CE460 Offset: 0x22CE561 VA: 0x22CE460
	|-MemoryMarshal.TryGetMemoryManager<byte, object>
	|
	|-RVA: 0x22CE550 Offset: 0x22CE651 VA: 0x22CE550
	|-MemoryMarshal.TryGetMemoryManager<char, object>
	|
	|-RVA: 0x22CE640 Offset: 0x22CE741 VA: 0x22CE640
	|-MemoryMarshal.TryGetMemoryManager<object, object>
	*/

	// RVA: 0x1B6A0E0 Offset: 0x1B6A1E1 VA: 0x1B6A0E0
	public static bool TryGetString(ReadOnlyMemory<char> memory, out string text, out int start, out int length) { }

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267810 Offset: 0x2267911 VA: 0x2267810
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267890 Offset: 0x2267991 VA: 0x2267890
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22677D0 Offset: 0x22678D1 VA: 0x22677D0
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267850 Offset: 0x2267951 VA: 0x2267850
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2562590 Offset: 0x2562691 VA: 0x2562590
	|-MemoryMarshal.Cast<double, byte>
	|
	|-RVA: 0x2562770 Offset: 0x2562871 VA: 0x2562770
	|-MemoryMarshal.Cast<int, byte>
	|
	|-RVA: 0x2562950 Offset: 0x2562A51 VA: 0x2562950
	|-MemoryMarshal.Cast<float, byte>
	|
	|-RVA: 0x2562B30 Offset: 0x2562C31 VA: 0x2562B30
	|-MemoryMarshal.Cast<Bounds, byte>
	|
	|-RVA: 0x2562D10 Offset: 0x2562E11 VA: 0x2562D10
	|-MemoryMarshal.Cast<Color, byte>
	|
	|-RVA: 0x2562EF0 Offset: 0x2562FF1 VA: 0x2562EF0
	|-MemoryMarshal.Cast<Quaternion, byte>
	|
	|-RVA: 0x25630D0 Offset: 0x25631D1 VA: 0x25630D0
	|-MemoryMarshal.Cast<Rect, byte>
	|
	|-RVA: 0x25632B0 Offset: 0x25633B1 VA: 0x25632B0
	|-MemoryMarshal.Cast<Vector2, byte>
	|
	|-RVA: 0x2563490 Offset: 0x2563591 VA: 0x2563490
	|-MemoryMarshal.Cast<Vector3, byte>
	|
	|-RVA: 0x2563670 Offset: 0x2563771 VA: 0x2563670
	|-MemoryMarshal.Cast<Vector4, byte>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(ReadOnlySpan<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25615B0 Offset: 0x25616B1 VA: 0x25615B0
	|-MemoryMarshal.Cast<byte, long>
	|
	|-RVA: 0x2561790 Offset: 0x2561891 VA: 0x2561790
	|-MemoryMarshal.Cast<byte, ushort>
	|
	|-RVA: 0x2561970 Offset: 0x2561A71 VA: 0x2561970
	|-MemoryMarshal.Cast<byte, uint>
	*/
}

public static class MemoryMarshal // TypeDefIndex: 4395
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CDE60 Offset: 0x22CDF61 VA: 0x22CDE60
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0x22CE060 Offset: 0x22CE161 VA: 0x22CE060
	|-MemoryMarshal.TryGetArray<char>
	|
	|-RVA: 0x22CE260 Offset: 0x22CE361 VA: 0x22CE260
	|-MemoryMarshal.TryGetArray<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetMemoryManager<T, TManager>(ReadOnlyMemory<T> memory, out TManager manager, out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CE460 Offset: 0x22CE561 VA: 0x22CE460
	|-MemoryMarshal.TryGetMemoryManager<byte, object>
	|
	|-RVA: 0x22CE550 Offset: 0x22CE651 VA: 0x22CE550
	|-MemoryMarshal.TryGetMemoryManager<char, object>
	|
	|-RVA: 0x22CE640 Offset: 0x22CE741 VA: 0x22CE640
	|-MemoryMarshal.TryGetMemoryManager<object, object>
	*/

	// RVA: 0x1B6A0E0 Offset: 0x1B6A1E1 VA: 0x1B6A0E0
	public static bool TryGetString(ReadOnlyMemory<char> memory, out string text, out int start, out int length) { }

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2267810 Offset: 0x2267911 VA: 0x2267810
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267890 Offset: 0x2267991 VA: 0x2267890
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22677D0 Offset: 0x22678D1 VA: 0x22677D0
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x2267850 Offset: 0x2267951 VA: 0x2267850
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2562590 Offset: 0x2562691 VA: 0x2562590
	|-MemoryMarshal.Cast<double, byte>
	|
	|-RVA: 0x2562770 Offset: 0x2562871 VA: 0x2562770
	|-MemoryMarshal.Cast<int, byte>
	|
	|-RVA: 0x2562950 Offset: 0x2562A51 VA: 0x2562950
	|-MemoryMarshal.Cast<float, byte>
	|
	|-RVA: 0x2562B30 Offset: 0x2562C31 VA: 0x2562B30
	|-MemoryMarshal.Cast<Bounds, byte>
	|
	|-RVA: 0x2562D10 Offset: 0x2562E11 VA: 0x2562D10
	|-MemoryMarshal.Cast<Color, byte>
	|
	|-RVA: 0x2562EF0 Offset: 0x2562FF1 VA: 0x2562EF0
	|-MemoryMarshal.Cast<Quaternion, byte>
	|
	|-RVA: 0x25630D0 Offset: 0x25631D1 VA: 0x25630D0
	|-MemoryMarshal.Cast<Rect, byte>
	|
	|-RVA: 0x25632B0 Offset: 0x25633B1 VA: 0x25632B0
	|-MemoryMarshal.Cast<Vector2, byte>
	|
	|-RVA: 0x2563490 Offset: 0x2563591 VA: 0x2563490
	|-MemoryMarshal.Cast<Vector3, byte>
	|
	|-RVA: 0x2563670 Offset: 0x2563771 VA: 0x2563670
	|-MemoryMarshal.Cast<Vector4, byte>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(ReadOnlySpan<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25615B0 Offset: 0x25616B1 VA: 0x25615B0
	|-MemoryMarshal.Cast<byte, long>
	|
	|-RVA: 0x2561790 Offset: 0x2561891 VA: 0x2561790
	|-MemoryMarshal.Cast<byte, ushort>
	|
	|-RVA: 0x2561970 Offset: 0x2561A71 VA: 0x2561970
	|-MemoryMarshal.Cast<byte, uint>
	*/
}

