package org.example;

public class User {
    private String login;
    private String email;

    public User(String... params) throws EmailException, LoginException {
        if (params.length == 0){
            this.login = "default-login";
            this.email = "example@mail.ru";
        }
        else if (params.length == 2){
            setLogin(params[0]);
            setEmail(params[1]);
        }
        else{
            throw new RuntimeException();
        }
    }

    public void setEmail(String value) throws EmailException {
        if (value.contains("@") == false || value.chars().filter(ch -> ch == '@').count() > 1)
            throw new EmailException();
        if (value.contains(".") == false)
            throw new EmailException();

        this.email = value;
    }

    public void setLogin(String value) throws LoginException{
        if (value.length() < 5) {
            throw new LoginException();
        }

        this.login = value;
    }

    public static class EmailException extends Exception{

    }

    public static class LoginException extends Exception {

    }
}
