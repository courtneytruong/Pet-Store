using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using PetStoreUI;
using PetStoreProductLogic;
using PetStoreProducts;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography.X509Certificates;
using FluentValidation;

namespace Pet_Store_class_exercise
{
    public class CatFoodValidator : AbstractValidator<CatFood>
    {
        public CatFoodValidator()
        {
            RuleFor(catFood => catFood.Name).NotEmpty();
            RuleFor(catFood => catFood.Price).GreaterThanOrEqualTo(0);
            RuleFor(catFood => catFood.Quantity).GreaterThanOrEqualTo(0);
            RuleFor(catFood => catFood.Description).MinimumLength(10).When(catFood => !string.IsNullOrEmpty(catFood.Description));  
        }
    }
}
