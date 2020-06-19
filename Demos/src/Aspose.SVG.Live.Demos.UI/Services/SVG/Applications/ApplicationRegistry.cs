using System;
using System.Collections.Generic;
using System.Linq;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Conversion;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Merger;
using Microsoft.Ajax.Utilities;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG.Applications
{
	public class ApplicationRegistry
	{
		private Dictionary<ApplicationId, Application> applications;
		static ApplicationRegistry instance;
		static object sync = new object();

		public static ApplicationRegistry Instance
		{
			get
			{
				if (instance == null)
				{
					lock (sync)
					{
						if (instance == null)
							instance = new ApplicationRegistry();
					}
				}

				return instance;
			}
		}


		ApplicationRegistry()
		{
			applications = new Dictionary<ApplicationId, Application>();

			// Conversion App
			Register<ConversionApplicationBuilder>(x => x
				.Handler(new SVGConversionHandler(), o => o
					.Filter(FileFormat.SVG, FileFormat.PDF, true)
					.Filter(FileFormat.SVG, FileFormat.XPS, true)
					.Filter(FileFormat.SVG, FileFormat.JPEG)
					.Filter(FileFormat.SVG, FileFormat.PNG)
					.Filter(FileFormat.SVG, FileFormat.BMP)
					.Filter(FileFormat.SVG, FileFormat.TIFF, true)
					.Filter(FileFormat.SVG, FileFormat.GIF)
				));

			// Merger App
			Register<MergerApplicationBuilder>(x => x
				.Handler(new SVGConversionHandler(), o => o
					.Filter(FileFormat.SVG, FileFormat.PDF, true)
					.Filter(FileFormat.SVG, FileFormat.XPS, true)
					.Filter(FileFormat.SVG, FileFormat.TIFF, true)
				).Handler(new SVGMergerHandler(), o => o
					.Filter(FileFormat.SVG, FileFormat.SVG)
				));
		}

		public Application Get(ApplicationId id)
		{
			return applications[id];
		}

		void Register<T>(Action<T> builder)
			where T : ApplicationBuilder, new()
		{
			var b = new T();
			builder(b);
			var app = b.Build();
			this.applications.Add(app.Id, app);
		}

		abstract class ApplicationBuilder
		{
			public abstract Application Build();
		}

		class ConversionApplicationBuilder : ApplicationBuilder
		{
			private IList<ConversionHandler> handlers = new List<ConversionHandler>();
			public override Application Build()
			{
				return new ConversionApplication(handlers.ToArray());
			}

			public ConversionApplicationBuilder Handler(ConversionHandler handler, Action<ConversionFilterBuilder> options)
			{
				var f = new ConversionFilterBuilder();
				options(f);
				f.Build().ForEach(x => handler.Filters.Add(x));
				handlers.Add(handler);
				return this;
			}
		}

		class ConversionFilterBuilder
		{
			IList<ConversionHandlerFilter> filters = new List<ConversionHandlerFilter>();

			public ConversionFilterBuilder Filter(FileFormat inputFormat, FileFormat outputFormat)
			{
				return Filter(inputFormat, outputFormat, false);
			}

			public ConversionFilterBuilder Filter(FileFormat inputFormat, FileFormat outputFormat, bool allowMerging)
			{
				this.filters.Add(new ConversionHandlerFilter(inputFormat, outputFormat, allowMerging));
				return this;
			}

			public IList<ConversionHandlerFilter> Build()
			{
				return filters;
			}
		}

		class MergerApplicationBuilder : ApplicationBuilder
		{
			private IList<ApplicationExecutionHandler> handlers = new List<ApplicationExecutionHandler>();

			public override Application Build()
			{
				return new MergerApplication(handlers.ToArray());
			}

			public MergerApplicationBuilder Handler(MergerHandler handler, Action<MergerFilterBuilder> options)
			{
				var f = new MergerFilterBuilder();
				options(f);
				f.Build().ForEach(x => handler.Filters.Add(x));
				handlers.Add(handler);
				return this;
			}

			public MergerApplicationBuilder Handler(ConversionHandler handler, Action<ConversionFilterBuilder> options)
			{
				var f = new ConversionFilterBuilder();
				options(f);
				f.Build().ForEach(x =>
				{
					handler.Filters.Add(x);
				});
				handlers.Add(handler);
				return this;
			}
		}

		class MergerFilterBuilder
		{
			IList<MergerHandlerFilter> filters = new List<MergerHandlerFilter>();

			public MergerFilterBuilder Filter(FileFormat inputFormat, FileFormat outputFormat)
			{
				this.filters.Add(new MergerHandlerFilter(inputFormat, outputFormat));
				return this;
			}

			public IList<MergerHandlerFilter> Build()
			{
				return filters;
			}
		}
	}
}
