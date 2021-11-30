﻿using Microsoft.Extensions.DependencyInjection;
using PatientWarningApp.Services.PatientServices;

namespace PatientWarningApp.Data
{
    public static class ServicesIoc
    {
        public static IServiceCollection AddServicesDi(this IServiceCollection services) {
            services.AddScoped<IPractitionerAccountService, PractitionerAccountService>();
            services.AddScoped<IPatientAccountService, PatientAccountService>();
            services.AddScoped<IPractitionerService, PractitionerService>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IMediaService, MediaService>();
            services.AddScoped<IReviewedMediaService, ReviewedMediaService>();
            services.AddScoped<IMedicalRecordService, MedicalRecordService>();

            return services;

        }
    }
}
