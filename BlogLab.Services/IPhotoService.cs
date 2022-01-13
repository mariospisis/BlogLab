using System;
using CloudinaryDotNet.Actions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BlogLab.Services
{
    public interface IPhotoService
    {
        public Task<ImageUploadResult> AddPhotoAsync(IFormFile file);

        public Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
