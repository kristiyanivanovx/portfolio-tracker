import './App.css';
import InvestmentContainer from './components/investments/InvestmentContainer';
import WidgetsContainer from './components/widgets/WidgetsContainer';
import useInvestments from './hooks/useInvestments';

import { InvestmentsPortal } from './contexts/investmentsContext';

function App() {
  const { investments, totalValue } = useInvestments();

  return (
    <InvestmentsPortal value={{ investments, totalValue }}>
      <div className='mx-auto min-h-screen bg-gray-100 dark:bg-gray-900 p-6'>
        <div className='md-flex'>
          <div className='md:shrink-0'>
            <WidgetsContainer />
            <InvestmentContainer />
          </div>
        </div>
      </div>
    </InvestmentsPortal>
  );
}

export default App;
