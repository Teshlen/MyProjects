//a class to store all the tutor lessons with other stuff too
using System;
using System.Collections.Generic;

namespace TutorAppPortableLibrary
{
	public class TutorClass
	{
		public string TutorClassName {
			get;
			set;
		}
		public List<TutorLessons> Lessons {
			get;
			set;
		}
	}
}

