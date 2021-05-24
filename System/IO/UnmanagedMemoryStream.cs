public class UnmanagedMemoryStream : Stream // TypeDefIndex: 676
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0xBA1D0 Offset: 0xBA2D1 VA: 0xBA1D0
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x18D4890 Offset: 0x18D4991 VA: 0x18D4890
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0xB87C0 Offset: 0xB88C1 VA: 0xB87C0
	// RVA: 0x18D4910 Offset: 0x18D4A11 VA: 0x18D4910
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x18D4C00 Offset: 0x18D4D01 VA: 0x18D4C00
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D49B0 Offset: 0x18D4AB1 VA: 0x18D49B0
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D4CF0 Offset: 0x18D4DF1 VA: 0x18D4CF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18D4D10 Offset: 0x18D4E11 VA: 0x18D4D10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18D4D20 Offset: 0x18D4E21 VA: 0x18D4D20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18D4D40 Offset: 0x18D4E41 VA: 0x18D4D40 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18D4D60 Offset: 0x18D4E61 VA: 0x18D4D60 Slot: 17
	public override void Flush() { }

	// RVA: 0x18D4E00 Offset: 0x18D4F01 VA: 0x18D4E00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18D4E20 Offset: 0x18D4F21 VA: 0x18D4E20 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18D4E60 Offset: 0x18D4F61 VA: 0x18D4E60 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18D4F30 Offset: 0x18D5031 VA: 0x18D4F30
	public byte* get_PositionPointer() { }

	// RVA: 0x18D50B0 Offset: 0x18D51B1 VA: 0x18D50B0 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB87E0 Offset: 0xB88E1 VA: 0xB87E0
	// RVA: 0x18D5430 Offset: 0x18D5531 VA: 0x18D5430 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D5790 Offset: 0x18D5891 VA: 0x18D5790 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18D58D0 Offset: 0x18D59D1 VA: 0x18D58D0 Slot: 24
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x18D5A20 Offset: 0x18D5B21 VA: 0x18D5A20 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8800 Offset: 0xB8901 VA: 0xB8800
	// RVA: 0x18D5E80 Offset: 0x18D5F81 VA: 0x18D5E80 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D6150 Offset: 0x18D6251 VA: 0x18D6150 Slot: 28
	public override void WriteByte(byte value) { }
}

public class UnmanagedMemoryStream : Stream // TypeDefIndex: 676
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0xBA1D0 Offset: 0xBA2D1 VA: 0xBA1D0
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x18D4890 Offset: 0x18D4991 VA: 0x18D4890
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0xB87C0 Offset: 0xB88C1 VA: 0xB87C0
	// RVA: 0x18D4910 Offset: 0x18D4A11 VA: 0x18D4910
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x18D4C00 Offset: 0x18D4D01 VA: 0x18D4C00
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D49B0 Offset: 0x18D4AB1 VA: 0x18D49B0
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D4CF0 Offset: 0x18D4DF1 VA: 0x18D4CF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18D4D10 Offset: 0x18D4E11 VA: 0x18D4D10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18D4D20 Offset: 0x18D4E21 VA: 0x18D4D20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18D4D40 Offset: 0x18D4E41 VA: 0x18D4D40 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18D4D60 Offset: 0x18D4E61 VA: 0x18D4D60 Slot: 17
	public override void Flush() { }

	// RVA: 0x18D4E00 Offset: 0x18D4F01 VA: 0x18D4E00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18D4E20 Offset: 0x18D4F21 VA: 0x18D4E20 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18D4E60 Offset: 0x18D4F61 VA: 0x18D4E60 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18D4F30 Offset: 0x18D5031 VA: 0x18D4F30
	public byte* get_PositionPointer() { }

	// RVA: 0x18D50B0 Offset: 0x18D51B1 VA: 0x18D50B0 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB87E0 Offset: 0xB88E1 VA: 0xB87E0
	// RVA: 0x18D5430 Offset: 0x18D5531 VA: 0x18D5430 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D5790 Offset: 0x18D5891 VA: 0x18D5790 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18D58D0 Offset: 0x18D59D1 VA: 0x18D58D0 Slot: 24
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x18D5A20 Offset: 0x18D5B21 VA: 0x18D5A20 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8800 Offset: 0xB8901 VA: 0xB8800
	// RVA: 0x18D5E80 Offset: 0x18D5F81 VA: 0x18D5E80 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D6150 Offset: 0x18D6251 VA: 0x18D6150 Slot: 28
	public override void WriteByte(byte value) { }
}

public class UnmanagedMemoryStream : Stream // TypeDefIndex: 676
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0xBA1D0 Offset: 0xBA2D1 VA: 0xBA1D0
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x18D4890 Offset: 0x18D4991 VA: 0x18D4890
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0xB87C0 Offset: 0xB88C1 VA: 0xB87C0
	// RVA: 0x18D4910 Offset: 0x18D4A11 VA: 0x18D4910
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x18D4C00 Offset: 0x18D4D01 VA: 0x18D4C00
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D49B0 Offset: 0x18D4AB1 VA: 0x18D49B0
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D4CF0 Offset: 0x18D4DF1 VA: 0x18D4CF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18D4D10 Offset: 0x18D4E11 VA: 0x18D4D10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18D4D20 Offset: 0x18D4E21 VA: 0x18D4D20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18D4D40 Offset: 0x18D4E41 VA: 0x18D4D40 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18D4D60 Offset: 0x18D4E61 VA: 0x18D4D60 Slot: 17
	public override void Flush() { }

	// RVA: 0x18D4E00 Offset: 0x18D4F01 VA: 0x18D4E00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18D4E20 Offset: 0x18D4F21 VA: 0x18D4E20 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18D4E60 Offset: 0x18D4F61 VA: 0x18D4E60 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18D4F30 Offset: 0x18D5031 VA: 0x18D4F30
	public byte* get_PositionPointer() { }

	// RVA: 0x18D50B0 Offset: 0x18D51B1 VA: 0x18D50B0 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB87E0 Offset: 0xB88E1 VA: 0xB87E0
	// RVA: 0x18D5430 Offset: 0x18D5531 VA: 0x18D5430 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D5790 Offset: 0x18D5891 VA: 0x18D5790 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18D58D0 Offset: 0x18D59D1 VA: 0x18D58D0 Slot: 24
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x18D5A20 Offset: 0x18D5B21 VA: 0x18D5A20 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8800 Offset: 0xB8901 VA: 0xB8800
	// RVA: 0x18D5E80 Offset: 0x18D5F81 VA: 0x18D5E80 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D6150 Offset: 0x18D6251 VA: 0x18D6150 Slot: 28
	public override void WriteByte(byte value) { }
}

public class UnmanagedMemoryStream : Stream // TypeDefIndex: 676
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0xBA1D0 Offset: 0xBA2D1 VA: 0xBA1D0
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x18D4890 Offset: 0x18D4991 VA: 0x18D4890
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0xB87C0 Offset: 0xB88C1 VA: 0xB87C0
	// RVA: 0x18D4910 Offset: 0x18D4A11 VA: 0x18D4910
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x18D4C00 Offset: 0x18D4D01 VA: 0x18D4C00
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D49B0 Offset: 0x18D4AB1 VA: 0x18D49B0
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D4CF0 Offset: 0x18D4DF1 VA: 0x18D4CF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18D4D10 Offset: 0x18D4E11 VA: 0x18D4D10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18D4D20 Offset: 0x18D4E21 VA: 0x18D4D20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18D4D40 Offset: 0x18D4E41 VA: 0x18D4D40 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18D4D60 Offset: 0x18D4E61 VA: 0x18D4D60 Slot: 17
	public override void Flush() { }

	// RVA: 0x18D4E00 Offset: 0x18D4F01 VA: 0x18D4E00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18D4E20 Offset: 0x18D4F21 VA: 0x18D4E20 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18D4E60 Offset: 0x18D4F61 VA: 0x18D4E60 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18D4F30 Offset: 0x18D5031 VA: 0x18D4F30
	public byte* get_PositionPointer() { }

	// RVA: 0x18D50B0 Offset: 0x18D51B1 VA: 0x18D50B0 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB87E0 Offset: 0xB88E1 VA: 0xB87E0
	// RVA: 0x18D5430 Offset: 0x18D5531 VA: 0x18D5430 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D5790 Offset: 0x18D5891 VA: 0x18D5790 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18D58D0 Offset: 0x18D59D1 VA: 0x18D58D0 Slot: 24
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x18D5A20 Offset: 0x18D5B21 VA: 0x18D5A20 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8800 Offset: 0xB8901 VA: 0xB8800
	// RVA: 0x18D5E80 Offset: 0x18D5F81 VA: 0x18D5E80 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D6150 Offset: 0x18D6251 VA: 0x18D6150 Slot: 28
	public override void WriteByte(byte value) { }
}

public class UnmanagedMemoryStream : Stream // TypeDefIndex: 676
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0xBA1D0 Offset: 0xBA2D1 VA: 0xBA1D0
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x18D4890 Offset: 0x18D4991 VA: 0x18D4890
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0xB87C0 Offset: 0xB88C1 VA: 0xB87C0
	// RVA: 0x18D4910 Offset: 0x18D4A11 VA: 0x18D4910
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x18D4C00 Offset: 0x18D4D01 VA: 0x18D4C00
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D49B0 Offset: 0x18D4AB1 VA: 0x18D49B0
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D4CF0 Offset: 0x18D4DF1 VA: 0x18D4CF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18D4D10 Offset: 0x18D4E11 VA: 0x18D4D10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18D4D20 Offset: 0x18D4E21 VA: 0x18D4D20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18D4D40 Offset: 0x18D4E41 VA: 0x18D4D40 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18D4D60 Offset: 0x18D4E61 VA: 0x18D4D60 Slot: 17
	public override void Flush() { }

	// RVA: 0x18D4E00 Offset: 0x18D4F01 VA: 0x18D4E00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18D4E20 Offset: 0x18D4F21 VA: 0x18D4E20 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18D4E60 Offset: 0x18D4F61 VA: 0x18D4E60 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18D4F30 Offset: 0x18D5031 VA: 0x18D4F30
	public byte* get_PositionPointer() { }

	// RVA: 0x18D50B0 Offset: 0x18D51B1 VA: 0x18D50B0 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB87E0 Offset: 0xB88E1 VA: 0xB87E0
	// RVA: 0x18D5430 Offset: 0x18D5531 VA: 0x18D5430 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D5790 Offset: 0x18D5891 VA: 0x18D5790 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18D58D0 Offset: 0x18D59D1 VA: 0x18D58D0 Slot: 24
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x18D5A20 Offset: 0x18D5B21 VA: 0x18D5A20 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8800 Offset: 0xB8901 VA: 0xB8800
	// RVA: 0x18D5E80 Offset: 0x18D5F81 VA: 0x18D5E80 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D6150 Offset: 0x18D6251 VA: 0x18D6150 Slot: 28
	public override void WriteByte(byte value) { }
}

public class UnmanagedMemoryStream : Stream // TypeDefIndex: 676
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0xBA1D0 Offset: 0xBA2D1 VA: 0xBA1D0
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x18D4890 Offset: 0x18D4991 VA: 0x18D4890
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0xB87C0 Offset: 0xB88C1 VA: 0xB87C0
	// RVA: 0x18D4910 Offset: 0x18D4A11 VA: 0x18D4910
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x18D4C00 Offset: 0x18D4D01 VA: 0x18D4C00
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D49B0 Offset: 0x18D4AB1 VA: 0x18D49B0
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D4CF0 Offset: 0x18D4DF1 VA: 0x18D4CF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18D4D10 Offset: 0x18D4E11 VA: 0x18D4D10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18D4D20 Offset: 0x18D4E21 VA: 0x18D4D20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18D4D40 Offset: 0x18D4E41 VA: 0x18D4D40 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18D4D60 Offset: 0x18D4E61 VA: 0x18D4D60 Slot: 17
	public override void Flush() { }

	// RVA: 0x18D4E00 Offset: 0x18D4F01 VA: 0x18D4E00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18D4E20 Offset: 0x18D4F21 VA: 0x18D4E20 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18D4E60 Offset: 0x18D4F61 VA: 0x18D4E60 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18D4F30 Offset: 0x18D5031 VA: 0x18D4F30
	public byte* get_PositionPointer() { }

	// RVA: 0x18D50B0 Offset: 0x18D51B1 VA: 0x18D50B0 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB87E0 Offset: 0xB88E1 VA: 0xB87E0
	// RVA: 0x18D5430 Offset: 0x18D5531 VA: 0x18D5430 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D5790 Offset: 0x18D5891 VA: 0x18D5790 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18D58D0 Offset: 0x18D59D1 VA: 0x18D58D0 Slot: 24
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x18D5A20 Offset: 0x18D5B21 VA: 0x18D5A20 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8800 Offset: 0xB8901 VA: 0xB8800
	// RVA: 0x18D5E80 Offset: 0x18D5F81 VA: 0x18D5E80 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D6150 Offset: 0x18D6251 VA: 0x18D6150 Slot: 28
	public override void WriteByte(byte value) { }
}

public class UnmanagedMemoryStream : Stream // TypeDefIndex: 676
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliantAttribute] // RVA: 0xBA1D0 Offset: 0xBA2D1 VA: 0xBA1D0
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x18D4890 Offset: 0x18D4991 VA: 0x18D4890
	protected void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0xB87C0 Offset: 0xB88C1 VA: 0xB87C0
	// RVA: 0x18D4910 Offset: 0x18D4A11 VA: 0x18D4910
	public void .ctor(byte* pointer, long length) { }

	// RVA: 0x18D4C00 Offset: 0x18D4D01 VA: 0x18D4C00
	internal void .ctor(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D49B0 Offset: 0x18D4AB1 VA: 0x18D49B0
	internal void Initialize(byte* pointer, long length, long capacity, FileAccess access, bool skipSecurityCheck) { }

	// RVA: 0x18D4CF0 Offset: 0x18D4DF1 VA: 0x18D4CF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18D4D10 Offset: 0x18D4E11 VA: 0x18D4D10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18D4D20 Offset: 0x18D4E21 VA: 0x18D4D20 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18D4D40 Offset: 0x18D4E41 VA: 0x18D4D40 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18D4D60 Offset: 0x18D4E61 VA: 0x18D4D60 Slot: 17
	public override void Flush() { }

	// RVA: 0x18D4E00 Offset: 0x18D4F01 VA: 0x18D4E00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18D4E20 Offset: 0x18D4F21 VA: 0x18D4E20 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18D4E60 Offset: 0x18D4F61 VA: 0x18D4E60 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18D4F30 Offset: 0x18D5031 VA: 0x18D4F30
	public byte* get_PositionPointer() { }

	// RVA: 0x18D50B0 Offset: 0x18D51B1 VA: 0x18D50B0 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB87E0 Offset: 0xB88E1 VA: 0xB87E0
	// RVA: 0x18D5430 Offset: 0x18D5531 VA: 0x18D5430 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D5790 Offset: 0x18D5891 VA: 0x18D5790 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18D58D0 Offset: 0x18D59D1 VA: 0x18D58D0 Slot: 24
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x18D5A20 Offset: 0x18D5B21 VA: 0x18D5A20 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB8800 Offset: 0xB8901 VA: 0xB8800
	// RVA: 0x18D5E80 Offset: 0x18D5F81 VA: 0x18D5E80 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18D6150 Offset: 0x18D6251 VA: 0x18D6150 Slot: 28
	public override void WriteByte(byte value) { }
}

