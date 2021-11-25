namespace NalogRu.BillJson.Models
{
    public record ProductRow
    {
        /// <summary>
        /// Название продукта
        /// </summary>
        public string Name { get; init; }
        /// <summary>
        /// количество в чеке
        /// </summary>
        public decimal Count { get; init; }
        /// <summary>
        /// цена
        /// </summary>
        public decimal Price { get; init; }
        /// <summary>
        /// Условные единицы товара ( литры , граммы , штуки)
        /// иногда в таре 1Л а иногда 0.5
        /// для правильного рассчета среднего
        /// </summary>
        public  decimal? Units { get; init; }
    }
}