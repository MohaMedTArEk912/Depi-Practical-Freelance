import { Box, Typography, Button } from '@mui/material';
import { useAuth } from '../context/AuthContext';
import { useNavigate } from 'react-router-dom';
import LogoutIcon from '@mui/icons-material/Logout';

export default function Dashboard() {
  const { user, logout } = useAuth();
  const navigate = useNavigate();

  const handleLogout = () => {
    logout();
    navigate('/login');
  };

  return (
    <Box
      sx={{
        height: '100vh',
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        background: 'linear-gradient(135deg, var(--background-start), var(--background-end))',
      }}
    >
      <Box
        sx={{
          p: 4,
          borderRadius: 2,
          bgcolor: 'rgba(255, 255, 255, 0.8)',
          backdropFilter: 'blur(10px)',
          textAlign: 'center',
          maxWidth: '400px',
          width: '100%',
          position: 'relative',
        }}
      >
        <Typography variant="h4" component="h1" sx={{ mb: 2 }}>
          Welcome, {user?.username}!
        </Typography>
        <Typography variant="body1" sx={{ color: 'text.secondary', mb: 4 }}>
          You are successfully logged in.
        </Typography>
        <Button
          variant="contained"
          color="primary"
          onClick={handleLogout}
          startIcon={<LogoutIcon />}
          sx={{
            mt: 2,
            backgroundColor: 'var(--primary-color)',
            '&:hover': {
              backgroundColor: 'var(--primary-dark)',
            },
          }}
        >
          Logout
        </Button>
      </Box>
    </Box>
  );
}
