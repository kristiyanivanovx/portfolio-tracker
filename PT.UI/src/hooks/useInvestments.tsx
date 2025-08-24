import { useEffect, useState } from 'react';
import type { Investment } from '../types/investment';
import axios from 'axios';

export default function useInvestments() {
  const apiUrl = 'https://localhost:5001/api';

  const [investments, setInvestments] = useState<Investment[]>([]);
  const totalValue = investments.reduce((acc, inv) => acc + inv.totalValue, 0);

  useEffect(() => {
    axios
      .get(apiUrl + '/investments')
      .then((res) => setInvestments(res.data.investments))
      .catch((err) => console.error(err));
  }, []);

  return {
    investments,
    totalValue,
  };
}
