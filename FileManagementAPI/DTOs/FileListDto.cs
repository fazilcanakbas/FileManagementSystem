﻿namespace FileManagementAPI.DTOs
{
    public class FileListDto
    {
        public List<FileDetailsDto> Files { get; set; } = new List<FileDetailsDto>();
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
    }
}