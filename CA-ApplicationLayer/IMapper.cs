namespace CA_ApplicationLayer
{
    public interface IMapper<TDTO, TOutPut>
    {
        public TOutPut ToEntity(TDTO dto);
    }
}
