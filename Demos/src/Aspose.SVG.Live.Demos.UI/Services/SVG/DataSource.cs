using System;
using System.IO;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG
{
	public abstract class DataSource : IDisposable
	{
		
		protected DataSource(string uri)
		{
			this.Uri = uri;
		}

		public virtual bool IsValid()
		{
			return true;
		}

		public virtual string Uri
		{
			get;
		}

		public virtual string Name
		{
			get { return Path.GetFileNameWithoutExtension(Uri); }
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources.
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{

		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
