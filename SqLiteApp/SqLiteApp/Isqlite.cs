﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqLiteApp
{
    public interface Isqlite
    {
        SQLiteConnection GetConnection();
    }
}
