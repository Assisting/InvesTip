using System;
using System.Collections.Generic;
using System.Text;

namespace InvesTip.DAL.Partials
{
    partial class UserWatchlist
    {
        public int ID;
        public int UserID;
        public int StockID;
        public bool StillOnWatchlist;
        public DateTime AddedDateTime;
        public DateTime RemovedDateTime;
    }
}
