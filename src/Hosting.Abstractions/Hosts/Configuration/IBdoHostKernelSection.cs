﻿namespace BindOpen.System.Hosting.Hosts
{
    public interface IBdoHostKernelSection
    {
        string ApplicationInstanceName { get; set; }
        string LibraryFolderPath { get; set; }
        int LoggingExpirationDayNumber { get; set; }
        string LoggingFileName { get; set; }
        string LoggingFolderPath { get; set; }
    }
}