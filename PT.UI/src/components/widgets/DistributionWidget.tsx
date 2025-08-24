import Highcharts from 'highcharts';
import HighchartsReact from 'highcharts-react-official';
import { InvestmentsPortal } from '../../contexts/investmentsContext';
import { use } from 'react';

export default function DistributionWidget() {
  const { investments } = use(InvestmentsPortal);

  const aggregated: Record<string, number> = {};

  investments.forEach((item) => {
    aggregated[item.assetType] = (aggregated[item.assetType] || 0) + 1;
  });

  const options = {
    chart: {
      height: '200px',
      width: null,
      type: 'pie',
      backgroundColor: 'transparent',
    },
    title: {
      text: null,
    },
    tooltip: {
      valueSuffix: '%',
    },
    series: [
      {
        name: 'Percentage',
        data: Object.entries(aggregated).map(([assetType, count]) => ({
          name: assetType,
          y: (count / investments.length) * 100,
        })),
      },
    ],
    plotOptions: {
      pie: {
        allowPointSelect: true,
        cursor: 'pointer',
        dataLabels: [
          {
            enabled: false,
          },
          {
            enabled: true,
            format: '{point.name}: {point.percentage:.1f}%',
          },
        ],
      },
    },
  };

  return (
    <div className='flex flex-col mx-auto h-75 w-full max-w-sm justify-center rounded-xl p-6 gap-3 shadow-lg outline outline-black/5 dark:bg-slate-800 dark:shadow-none dark:-outline-offset-1 dark:outline-white/10'>
      <p className='text-xl text-center font-medium dark:text-white'>
        Portfolio Distribution
      </p>
      <div className='text-xl text-center font-medium dark:text-white overflow-x-auto'>
        <HighchartsReact highcharts={Highcharts} options={options} />
      </div>
    </div>
  );
}
