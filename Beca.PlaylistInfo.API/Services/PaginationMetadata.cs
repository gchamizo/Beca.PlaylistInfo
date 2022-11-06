﻿namespace Beca.PlaylistInfo.API.Services
{

    public class PaginationMetadata
    {
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public PaginationMetadata(int pageSize, int currentPage)
        {
            PageSize = pageSize;
            CurrentPage = currentPage;

        }
    }
        
}
