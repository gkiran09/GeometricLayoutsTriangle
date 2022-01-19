using GeometricLayoutTriangle.BusinessLogic.Interfaces;


namespace GeometricLayoutTriangle.BusinessLogic.Classes
{
    public class InputValidator : IInputValidator
    {
        public bool RowIsValid(string row) => RowMapper.ValidRow(row);
        public bool ColumnIsValid(int colum) => colum > 0 && colum < 13;
    }
}