using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProgrammersBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Filters
{
    // test push 2 falan
    public class MvcExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _environment;
        private readonly IModelMetadataProvider _modelMetaDataProvider;
        private readonly ILogger _logger;
        public MvcExceptionFilter(IHostEnvironment environment, IModelMetadataProvider modelMetaDataProvider, ILogger<MvcExceptionFilter> logger)
        {
            _environment = environment;
            _modelMetaDataProvider = modelMetaDataProvider;
            _logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            if (_environment.IsDevelopment()) //Proje yayınlanınca _environment.IsProduction olmalı
            {
                context.ExceptionHandled = true;
                var mvcErrorModel = new MvcErrorModel();
                var result = new ViewResult ();
                switch (context.Exception)
                {
                    case SqlNullValueException:
                        mvcErrorModel.Message = "Üzgünüz , beklenmedik bir veritabanı hatası oluştu.Sorunu en kısa sürede çözeceğiz.";
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 500;
                        _logger.LogError(context.Exception, context.Exception.Message);
                        break;
                    case NullReferenceException:
                        mvcErrorModel.Message = "Üzgünüz , beklenmedik bir null veriye rastlandı.Sorunu en kısa sürede çözeceğiz.";
                        result = new ViewResult { ViewName = "Error" }; //Error yazısı Error Pageiyle aynı olmalıdır.
                        result.StatusCode = 403;
                        _logger.LogError(context.Exception, context.Exception.Message);
                        break;
                    default: mvcErrorModel.Message = "Üzgünüz , beklenmedik bir hata oluştu.Sorunu en kısa sürede çözeceğiz.";
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 500;
                        _logger.LogError(context.Exception, context.Exception.Message);
                        break;
                }

                result.ViewData = new ViewDataDictionary(_modelMetaDataProvider, context.ModelState);
                result.ViewData.Add("MvcErrorModel", mvcErrorModel);
                context.Result = result;
            }
        }
    }
}
