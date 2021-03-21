using ComparaItens.Domain.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System.Collections.Generic;

namespace ComparaItens.Domain.Commands
{
    public class ProductInsertCommand : Notifiable, ICommand
    {
        public string Description { get; set; }
        public string Model { get; set; }
        public int CategoryId { get; set; }
        public int ManufecturerId { get; set; }
        public int YearOfManufacture { get; set; }
        public string Image { get; set; }
        public string Folder { get; set; }
        public IList<SpecificationItem> SpecificationItems { get; set; }

        public ProductInsertCommand()
        {
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotNullOrEmpty(Description, "Description", "Descrição não pode ser nulo")
                    .IsNotNullOrEmpty(Model, "Model", "Model não pode ser nulo")
                    .IsGreaterThan(CategoryId, 0, "CategoryId", "O CategoryId é obrigatório")
                    .IsGreaterThan(ManufecturerId, 0, "ManufecturerId", "O ManufecturerId é obrigatório")
                    .IsGreaterThan(YearOfManufacture, 0, "YearOfManufacture", "O YearOfManufacture é obrigatório")
                    .IsNotNullOrEmpty(Image, "Image", "Image não pode ser nulo")
                    .IsNotNullOrEmpty(Folder, "Folder", "Folder não pode ser nulo")
            );
        }
    }
}