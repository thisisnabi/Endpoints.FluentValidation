namespace FluentValidation;

public static class ValidatorExtensions
{
    public static RouteHandlerBuilder Validator<T>(this RouteHandlerBuilder handlerBuilder)
        where T : class
    {
        handlerBuilder.AddEndpointFilter<ValidatorFilter<T>>();
        return handlerBuilder;
    }
}