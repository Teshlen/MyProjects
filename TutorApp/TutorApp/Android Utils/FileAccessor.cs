using System;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using TutorAppPortableLibrary.Models;

namespace TutorApp
{
	public class FileAccessor
	{
		public async Task<string> ReadStringAsync(string file)
		{
			string filePath = "";

			try
			{
				var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				filePath = Path.Combine(documentsPath, file);

				return File.ReadAllText(filePath);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Unable to read from '" + filePath + "': " + ex);
				return "";
			}
		}

		public async Task<FileReadResult<T>> ReadObjectAsync<T>(string file)
		{
			var text = await ReadStringAsync(file);

			if (string.IsNullOrEmpty(text))
			{
				return new FileReadResult<T>
				{
					Success = false
				};
			}

			return new FileReadResult<T>
			{
				Success = true,
				Data = JsonConvert.DeserializeObject<T>(text)
			};
		}

		public async Task WriteStringAsync(string file, string text)
		{
			string filePath = "";

			try
			{
				var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				filePath = Path.Combine(documentsPath, file);
				File.WriteAllText(filePath, text);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine("Unable to write to '" + filePath + "': " + ex);
			}
		}

		public async Task WriteObjectAsync(string file, object toWrite)
		{
			await WriteStringAsync(file, JsonConvert.SerializeObject(toWrite));
		}
	}
}

