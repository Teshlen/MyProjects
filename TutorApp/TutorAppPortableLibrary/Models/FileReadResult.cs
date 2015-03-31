using System;

namespace TutorAppPortableLibrary.Models
{
	public struct FileReadResult<T>
	{
		public bool Success;
		public T Data;
	}
}

