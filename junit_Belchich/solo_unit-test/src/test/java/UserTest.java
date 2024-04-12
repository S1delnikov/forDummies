import org.junit.jupiter.api.*;
import org.junit.jupiter.api.Assertions.*;
import org.example.User;
import org.example.User.EmailException;
import org.example.User.LoginException;

public class UserTest {
    @Test
    @DisplayName("Проверка создания объекта с двумя параметрами")
    public void testTwoArgUser() {
        Assertions.assertDoesNotThrow(() -> new User("mylogin", "example@mail.ru"));
    }

    @Test
    @DisplayName("Проверка создания объекта без параметров")
    public void testZeroArgUser() {
        Assertions.assertDoesNotThrow(() -> new User());
    }

    @Test
    @DisplayName("Проверка email")
    public void testSetEmail() {
        Assertions.assertThrows(EmailException.class, () -> new User("login", "incorrect-mail-ru"));
    }

    @Test
    @DisplayName("Проверка логина")
    public void testSetLogin() {
        Assertions.assertThrows(LoginException.class, () -> new User("bad", "cool@mail.ru"));
    }
}
