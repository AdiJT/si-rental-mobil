using SIRentalMobil.Domain.Commons;

namespace SIRentalMobil.Web.Services.FileUpload;

public interface IFileUploadService
{
    Task<Result<Uri>> UploadFile<TModel>(IFormFile formFile, string folderPath, string[] permittedExtension, long minSizeLimit, long maxSizeLimit);
}
